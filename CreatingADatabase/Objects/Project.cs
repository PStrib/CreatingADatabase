using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingADatabase.Objects
{
    class Project
    {
        private decimal projectBudget;
        private int projectCode;
        private string managerName;
        private string projectName;
        private DateTime projectStartDate;
        private DateTime projectEndDate;
        private bool projectCompleted;

        public Project()
        {

        }

        public Project(decimal ProjectBudget, int ProjectCode, string ManagerName, string ProjectName, DateTime ProjectStartDate, DateTime ProjectEndDate, bool ProjectCompleted)
        {
            projectBudget = ProjectBudget;
            projectCode = ProjectCode;
            managerName = ManagerName;
            projectName = ProjectName;
            projectStartDate = ProjectStartDate;
            projectEndDate = ProjectEndDate;
            projectCompleted = ProjectCompleted;
        }

        public decimal ProjectBudget
        {
            get
            {
                return projectBudget;
            }

            set
            {
                if (CheckBudgetFormat(value))
                    projectBudget = value;
                else
                    throw new Exception("Budget must be less than £100,000 and have no more than 2 decimal places");
            }
        }

        public int ProjectCode
        {
            get
            {
                return projectCode;
            }

            set
            {
                projectCode = value;
            }
        }

        public string ManagerName
        {
            get
            {
                return managerName;
            }

            set
            {
                if (CheckPresent(value))
                    managerName = value;
                else
                    throw new Exception("Manager Name cannot be left blank");
            }
        }

        public string ProjectName
        {
            get
            {
                return projectName;
            }

            set
            {
                projectName = value;
            }
        }

        public DateTime ProjectStartDate
        {
            get
            {
                return projectStartDate;
            }

            set
            {
                if (CheckProjectDay(value))
                    projectStartDate = value;
                else
                    throw new Exception("Projects must start between Monday and Friday");
            }
        }

        public DateTime ProjectEndDate
        {
            get
            {
                return projectEndDate;
            }

            set
            {
                if (CheckEndDate(value))
                    projectEndDate = value;
                else
                    throw new Exception("Projects must end between Monday and Friday and be at least 7 days long"); // The seven day time gap isn't working ask for help!!
            }
        }

        public bool ProjectCompleted
        {
            get
            {
                return projectCompleted;
            }

            set
            {
                projectCompleted = value;
            }
        }

        private bool CheckPresent(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return false;
            else
                return true;
        }

        private bool CheckProjectDay(DateTime value)
        {
            if ((int)value.DayOfWeek == 0 || (int)value.DayOfWeek == 6)
                return false;
            else
                return true;
        }

        private bool CheckEndDate(DateTime value)
        {
            if (CheckProjectDay(value) && value >= projectStartDate.AddDays(7))
                return true;
            else
                return false;
        }

        private bool CheckBudgetFormat(decimal value)
        {
            if (value <= (decimal)100000.00 && decimal.Round(value, 3) == value)
                return true;
            else
                return false;
        }
    }
}
