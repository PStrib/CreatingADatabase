using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingADatabase.Objects
{
    class Room
    {
        private int roomID;
        private string description;

        public Room()
        {}

        public Room (int roomID, string description)
        {
            roomID = RoomID;
            description = Description;
        }

        public int RoomID
        {
            get
            {
                return roomID;
            }

            set
            {
                roomID = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }
    }
}
