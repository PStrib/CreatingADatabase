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

        // Validates and records a booking and returns true if no collisions are detected.
        public bool AddNewBooking(int clientID, DateTime startDateTime, DateTime endDateTime, int roomNo, string staffName)
        {
            List<RoomBooking> bookings = GetDateRange(startDateTime, endDateTime);
            foreach (RoomBooking b in bookings)
            {
                if (b.office == roomNo)
                {
                    return false;
                }
            }
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = $@"
                                INSERT INTO Reservation
                              (CreationDate, Staff, ClientID)
                             VALUES ('{FormatDateTime(DateTime.Today)}', '{staffName}', {clientID});

                              

                         insert into [reservation-Room]
                        values ((SELECT MAX (ReservationID) FROM Reservation),{roomNo},'{FormatDateTime(endDateTime)}',0,'{FormatDateTime(startDateTime)}')";
            db.Cmd.ExecuteNonQuery();
            return true;
        }

        //We have to use this format for compatibility with SQL Server
        public string FormatDateTime(DateTime t)
        {
            return t.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK");
        }

        public List<RoomBooking> GetDateRange(DateTime viewStart, DateTime viewEnd)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = $@"
                                select roomid,
                                startDate,
                                endDate
                                FROM [Reservation-Room]

                                where not(enddate < CAST('{FormatDateTime(viewStart)}' AS date)
                                OR startdate > CAST('{FormatDateTime(viewEnd)}' AS date));";

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
