using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreatingADatabase.Objects;

namespace CreatingADatabase.DBAccess
{
    class RoomDBAccess
    {
        private Database db;

        public RoomDBAccess(Database _db)
        {
            db = _db;
        }

        public Room GetRoomFromDataReader()
        {
            Room r = new Objects.Room();
            r.RoomID = db.Reader.GetInt32(0);
            r.Description = db.Reader.GetString(1);
            return r;
        }
    }
}
