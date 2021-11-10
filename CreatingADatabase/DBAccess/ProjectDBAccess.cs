using CreatingADatabase.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingADatabase.DBAccess
{
    class ProjectDBAccess
    {
        private Database db;

        public ProjectDBAccess(Database _db)
        {
            db = _db;
        }

        public Project GetProjectFromDataReader()
        {
            Project proj = new Objects.Project();
            proj.ProjectCode = db.Reader.GetInt32(0);
            proj.ProjectName = db.Reader.GetString(1);
            proj.ManagerName = db.Reader.GetString(2);
            proj.ProjectBudget = db.Reader.GetDecimal(3);
            proj.ProjectStartDate = db.Reader.GetDateTime(4);
            proj.ProjectEndDate = db.Reader.GetDateTime(5);
            proj.ProjectCompleted = db.Reader.GetBoolean(6);
            return proj;
        }

        public void UpdateProject(Project p)//---------This will be very useful
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "update Project set ProjectTitle= '" + p.ProjectName
            + "', ProjectManager= '" + p.ManagerName + "', ProjectBudget= " + p.ProjectBudget +
            ", projectStartDate= '" + p.ProjectStartDate.ToString("MM/dd/yyyy") + "', ProjectEndDate= '" + p.ProjectEndDate.ToString("MM/dd/yyyy") +
            "', ProjectCompleted= '" + p.ProjectCompleted + "' where ProjectCode= " + p.ProjectCode;
            db.Cmd.ExecuteNonQuery();
        }

        public List<Project> GetProjectObjectList()
        {
            List<Project> results = new List<Project>();
            while (db.Reader.Read()) 
            {
                results.Add(GetProjectFromDataReader());
            }
            db.Reader.Close();
            return results;
        }

        public Project GetProjectObject()
        {
            Project project = new Project();
            while (db.Reader.Read())
            {
                project = GetProjectFromDataReader();
            }
            db.Reader.Close();
            return project;
        }

        public int GetLastProjectID()
        {
            string sqlCmd = "SELECT max(ProjectCode) FROM Project";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Reader = db.Cmd.ExecuteReader();
            db.Reader.Read();
            int ProjectCode = db.Reader.GetInt32(0);
            db.Reader.Close();
            return ProjectCode;
        }

        public DataTable GetProjectDataTable()
        {
            DataTable dt = new DataTable();
            dt.Load(db.Reader);
            return dt;
        }

        public void GetAllProjects()
        {
            string sqlCmd = "SELECT * FROM Project";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Reader = db.Cmd.ExecuteReader();
            db.Reader.Close();
        }

        public void GetEmployeesFromProject(int projCode)
        {
            string sqlCmd = ("SELECT Employee.EmployeeNo, Employee.EmployeeName, Employee.DepartmentNo, Department.DepartmentName FROM Project INNER JOIN ProjectEmployee ON ProjectEmployee.ProjectCode = Project.ProjectCode INNER JOIN Employee ON Employee.EmployeeNo = ProjectEmployee.EmployeeNo INNER JOIN Department ON Department.DepartmentNo = Employee.DepartmentNo WHERE Project.ProjectCode ='"+projCode+"';");
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Reader = db.Cmd.ExecuteReader();
        }

        public int GetEmployeeCountOnProject(int projCode)
        {

            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT Count(ProjectEmployee.EmployeeNo)FROM ProjectEmployee WHERE ProjectCode = " + projCode + " GROUP BY ProjectCode";
            int count = (int)db.Cmd.ExecuteScalar();

            return count;

        }


        public void GetProjectsWithID(int projCode)
        {
            string sqlCmd = "SELECT * FROM Project WHERE ProjectCode =" + projCode.ToString();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Reader = db.Cmd.ExecuteReader();
        }

        public void GetProjectsWithName(string projName)
        {
            string sqlCmd = ("SELECT * FROM Project WHERE ProjectTitle LIKE '" + projName+"%'");
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Reader = db.Cmd.ExecuteReader();
        }

        public void GetAllProjectsWithBudget (decimal rate, int op)
        {
            string sqlCmd = "SELECT * FROM Project WHERE ProjectBudget";
            switch(op)
            {
                case 1: sqlCmd += "="; break;
                case 2: sqlCmd += ">="; break;
                case 3: sqlCmd += "<="; break;
                case 4: sqlCmd += ">"; break;
                case 5: sqlCmd += "<"; break;
                case 6: sqlCmd += "<>"; break;
                default: sqlCmd += "="; break;
            }

            sqlCmd += rate.ToString();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Reader = db.Cmd.ExecuteReader();
        }

        public void GetAllProjectsWithManager(string manager)
        {
            string sqlCmd = "SELECT * FROM Project WHERE ProjectManager = '" + manager + "'";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Reader = db.Cmd.ExecuteReader();
        }

        public void AddNewProject (Project p)//----------------USEFUL
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "insert into Project (ProjectTitle, ProjectManager, ProjectBudget, ProjectStartDate, ProjectEndDate, ProjectCompleted) values ('" + p.ProjectName + "','" + p.ManagerName + "','" +
            p.ProjectBudget + "','" + p.ProjectStartDate.ToString("MM/dd/yyyy") + "','" + p.ProjectEndDate.ToString("MM/dd/yyyy") +
            "','" + p.ProjectCompleted + "')";
            db.Cmd.ExecuteNonQuery();
        }
    }
}
