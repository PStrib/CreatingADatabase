using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingADatabase.Objects
{
    class ProjectEmployee
    {
        private int projectCode;
        private int employeeNo;
        private decimal hourlyRate;

        public ProjectEmployee(int ProjectCode, int EmployeeNo, decimal HourlyRate)
        {
            projectCode = ProjectCode;
            employeeNo = EmployeeNo;
            hourlyRate = HourlyRate;
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

        public int EmployeeNo
        {
            get
            {
                return employeeNo;
            }

            set
            {
                employeeNo = value;
            }
        }

        public decimal HourlyRate
        {
            get
            {
                return hourlyRate;
            }

            set
            {
                hourlyRate = value;
            }
        }
    }
}
