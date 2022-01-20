using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingADatabase.Objects
{
    class Reservation
    {
        private int reservationID;
        private DateTime creationDate;
        private string staff;
        private int clientID;

        public Reservation()
        { }

        public Reservation (int reservationID, DateTime creationDate, string staff, int clientID)
        {
            reservationID = ReservationID;
            creationDate = CreationDate;
            staff = Staff;
            clientID = ClientID;
        }

        public int ReservationID
        {
            get
            {
                return reservationID;
            }

            set
            {
                reservationID = value;
            }
        }

        public DateTime CreationDate
        {
            get
            {
                return creationDate;
            }

            set
            {
                creationDate = value;
            }
        }

        public string Staff
        {
            get
            {
                return staff;
            }
            set
            {
                staff = value;
            }
        }

        public int ClientID
        {
            get
            {
                return clientID;
            }
            set
            {
                clientID = value;
            }
        }
    }
}
