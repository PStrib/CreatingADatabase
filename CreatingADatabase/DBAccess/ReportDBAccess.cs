using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreatingADatabase.Objects;

namespace CreatingADatabase.DBAccess
{
    class ReportDBAccess
    {
        private Database db;

        public ReportDBAccess(Database _db)
        {
            db = _db;
        }

        public void reportGeneration(string SQLString, List<string> selected)
        {
            string sqlCmd = SQLString;
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Reader = db.Cmd.ExecuteReader();
        }
    }
}
