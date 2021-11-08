using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreatingADatabase.Objects;

namespace CreatingADatabase.DBAccess
{
    class ProjectEmployeeDBAccess
    {
        private Database db;
        public ProjectEmployeeDBAccess(Database _db)
        {
            db = _db;
        }
        public void AddNewProjectEmployee(ProjectEmployee pe)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "insert into ProjectEmployee (ProjectCode, EmployeeNo) values (" + pe.ProjectCode + "," + pe.EmployeeNo + ")";
            db.Cmd.ExecuteNonQuery();
        }
    }
}
