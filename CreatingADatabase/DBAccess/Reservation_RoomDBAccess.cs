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

        public void GetReservationRoom(string month, string year)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "select roomid, concat(month(startdate),'/',year(startdate)) as StartDate, concat(month(enddate),'/', year(enddate)) as EndDate from[reservation - room]" +
                "where month(startdate)>= " + month + " and year(startdate)= " + year;
            SqlDataReader r=db.Cmd.ExecuteReader();

        }
    }
}
