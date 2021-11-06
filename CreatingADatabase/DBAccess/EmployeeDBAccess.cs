using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreatingADatabase.Objects;
using System.Data;

namespace CreatingADatabase.DBAccess
{
    class EmployeeDBAccess
    {
        private Database db;
        public EmployeeDBAccess(Database _db)
        {
            db = _db;
        }

        public Employee GetEmployeeFromDataReader()
        {
            Employee emp = new Objects.Employee();
            emp.EmployeeNo = db.Reader.GetInt32(0);
            emp.EmployeeName = db.Reader.GetString(1);
            emp.DepartmentNo = db.Reader.GetInt32(2);
            return emp;
        }

        public void GetAllEmployees()
        {
            string sqlCmd = "SELECT * FROM Employee order by EmployeeName";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Reader = db.Cmd.ExecuteReader();
        }

        public List<Employee> GetEmployeeObjectList()
        {
            List<Employee> results = new List<Employee>();
            while (db.Reader.Read())
            {
                results.Add(GetEmployeeFromDataReader());
            }
            db.Reader.Close();
            return results;
        }
        public Employee GetEmployeeObject()
        {
            Employee employee = new Employee();
            while (db.Reader.Read())
            {
                employee = GetEmployeeFromDataReader();
            }
            db.Reader.Close();
            return employee;
        }

        public void GetEmployeesByName(string employee)
        {
            string sqlCmd = "SELECT * FROM Employee WHERE EmployeeName = '" + employee + "'";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Reader = db.Cmd.ExecuteReader();
        }
    }
}
