﻿using System;
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
            List<RoomBooking> bookings = GetDateRange(startDateTime, endDateTime, roomNo);

            if (!bookings.Any())
            {
                return false;
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

        public bool AddNewConferenceBooking(
            int clientID,
            DateTime startDateTime,
            DateTime endDateTime,
            string cateringReqs,
            int attendees,
            bool isMorning,
            string staffName)
        {
            List<ConferenceRoomBooking> bookings = GetConferenceDateRange(startDateTime, endDateTime);
            foreach (ConferenceRoomBooking b in bookings)
            {
                if (b.isMorning == isMorning)
                {
                    return false;
                }
            }

            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = $@"
                                INSERT INTO Reservation
                              (CreationDate, Staff, ClientID)
                             VALUES ('{FormatDateTime(DateTime.Today)}', '{staffName}', {clientID});

                         insert into [reservation_Conference]
                         (ReservationID, StartDate, EndDate, CateringReqs, Attendees, isMorning)
                        values ((SELECT MAX (ReservationID) FROM Reservation),
                       '{startDateTime.Date:o}', '{endDateTime.Date:o}', '{cateringReqs}', 
                      {attendees}, '{isMorning}')";
            db.Cmd.ExecuteNonQuery();
            return true;
        }

        //We have to use this format for compatibility with SQL Server
        public string FormatDateTime(DateTime t)
        {
            return t.ToString("o");
        }

        public List<RoomBooking> GetDateRange(DateTime viewStart, DateTime viewEnd, int officeNo)
        {

            return FindBookingsFromQuery($@"
                                select roomid,
                                startDate,
                                endDate
                                FROM [Reservation-Room]

                                where roomid={officeNo} AND 
                                    not(enddate < CAST('{FormatDateTime(viewStart)}' AS date)
                                        OR startdate > CAST('{FormatDateTime(viewEnd)}' AS date));");
        }

        private List<RoomBooking> FindBookingsFromQuery(string query)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = query;

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

        public List<RoomBooking> GetDateRange(DateTime viewStart, DateTime viewEnd)
        {
            return FindBookingsFromQuery($@"
                                select roomid,
                                startDate,
                                endDate
                                FROM [Reservation-Room]

                                where not(enddate < CAST('{viewStart.Date:o}' AS date)
                                OR startdate > CAST('{viewEnd.Date:o}' AS date));");
        }

        public List<ConferenceRoomBooking> GetConferenceDateRange(DateTime viewStart, DateTime viewEnd)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = $@"
                                select isMorning,
                                startDate,
                                endDate
                                FROM [Reservation_Conference]

                                where not(enddate < CAST('{FormatDateTime(viewStart)}' AS date)
                                OR startdate > CAST('{FormatDateTime(viewEnd)}' AS date));";

            List<ConferenceRoomBooking> roomBookings = new List<ConferenceRoomBooking>();
            using (SqlDataReader reader = db.Cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        roomBookings.Add(new ConferenceRoomBooking(
                            isMorning: reader.GetBoolean(0),
                            startDate: reader.GetDateTime(1),
                            endDate: reader.GetDateTime(2)));
                    }
                }
            }
            return roomBookings;
        }
    }

    abstract class AbstractRoomBooking
    {
        public DateTime startDate, endDate;
    }

    class RoomBooking: AbstractRoomBooking
    {
        public int office;
        
        public RoomBooking(int office, DateTime startDate, DateTime endDate)
        {
            this.office = office;
            this.startDate = startDate;
            this.endDate = endDate;
        }
    }

    class ConferenceRoomBooking: AbstractRoomBooking
    {
        public bool isMorning;
        public ConferenceRoomBooking(bool isMorning, DateTime startDate, DateTime endDate)
        {
            this.isMorning = isMorning;
            this.startDate = startDate;
            this.endDate = endDate;
        }
    }
}
