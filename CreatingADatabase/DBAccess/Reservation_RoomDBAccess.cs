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
            db.Cmd.CommandText = $@"DECLARE @viewStart date;
                                DECLARE @viewEnd date;
                                set @viewStart=CAST ('{viewStart}' AS date);
                                set @viewEnd=CAST ('{viewEnd}' AS date);

                                select roomid,
                                month(startdate) as StartMonth,
                                year(startdate) as StartYear,
                                month(enddate) as EndMonth,
                                year(enddate) as EndYear
                                FROM [Reservation-Room]

                                where not(enddate<@viewStart
                                OR startdate>@viewEnd);";

            List<RoomBooking> roomBookings = new List<RoomBooking>();
            SqlDataReader reader=db.Cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    List<int> row = new List<int>();
                    for (int column = 0; column < 5; column++)
                    {
                        row.Add(reader.GetInt32(column));
                    }
                    roomBookings.Add(new RoomBooking(
                        office: row[0],
                        startMonth: row[1],
                        startYear: row[2],
                        endMonth: row[3],
                        endYear: row[4]));
                }
            }
            reader.Close();
            return roomBookings;
        }
    }
    class RoomBooking
    {
        public int office, startMonth, startYear, endMonth, endYear;

        public RoomBooking(int office, int startMonth, int startYear, int endMonth, int endYear)
        {
            this.office = office;
            this.startMonth = startMonth;
            this.startYear = startYear;
            this.endMonth = endMonth;
            this.endYear = endYear;
        }
    }
}
