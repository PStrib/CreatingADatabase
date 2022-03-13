using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreatingADatabase.Objects;

namespace CreatingADatabase.DBAccess
{
    class Reservation_RoomDBAccess
    {
        private Database db;
        public Reservation_RoomDBAccess(Database _db)
        {
            db = _db;
        }

        public void AddNewBooking(int ClientID, DateTime StartDate, DateTime EndDate, int RoomNo, string StaffName)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = $@"
                                INSERT INTO Reservation
                              (CreationDate, Staff, ClientID)
                             VALUES ('{JustDate(DateTime.Today)}', '{StaffName}', {ClientID});

                              

                         insert into [reservation-Room]
                        values ((SELECT MAX (ReservationID) FROM Reservation),{RoomNo},'{JustDate(EndDate)}',0,'{JustDate(StartDate)}')";
            db.Cmd.ExecuteNonQuery();
        }

        //We have to use this format for compatibility with SQL Server
        public string JustDate(DateTime t)
        {
            return t.ToString("MM/dd/yyyy");
        }

        public List<RoomBooking> GetDateRange(DateTime viewStart, DateTime viewEnd)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = $@"
                                select roomid,
                                startDate,
                                endDate
                                FROM [Reservation-Room]

                                where not(enddate < CAST('{JustDate(viewStart)}' AS date)
                                OR startdate > CAST('{JustDate(viewEnd)}' AS date));";

            List<RoomBooking> roomBookings = new List<RoomBooking>();
            using (SqlDataReader reader = db.Cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        roomBookings.Add(new RoomBooking(
                            office: reader.GetInt32(0),
                            startDate: reader.GetDateTime(1),
                            endDate: reader.GetDateTime(2)));
                    }
                }
            }
            return roomBookings;
        }
    }
    class RoomBooking
    {
        public int office;
        public DateTime startDate, endDate;

        public RoomBooking(int office, DateTime startDate, DateTime endDate)
        {
            this.office = office;
            this.startDate = startDate;
            this.endDate = endDate;
        }
    }
}
