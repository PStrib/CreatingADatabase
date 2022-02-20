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

        public void AddNewReservation_Room(Reservation_Room rr)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "insert into Reservation-Room (ReservationID, RoomID, EndDate, DepositPaid?, StartDate)" +
                " values (" + rr.ReservationID + "," + rr.RoomID + "," + rr.EndDate + "," + rr.DepositPaid +"," + rr.StartDate+ ")";
            db.Cmd.ExecuteNonQuery();
        }

        public List<RoomBooking> GetDateRange(DateTime viewStart, DateTime viewEnd)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = $@"
                                select roomid,
                                startDate,
                                endDate
                                FROM [Reservation-Room]

                                where not(enddate < CAST('{viewStart}' AS date)
                                OR startdate > CAST('{viewEnd}' AS date));";

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
