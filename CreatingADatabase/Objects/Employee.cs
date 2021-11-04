using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingADatabase.Objects
{
    class Employee
    {
        private int employeeNo;
        private string employeeName;
        private int departmentNo;

        public Employee()
        { }

        public Employee(int EmployeeNo, string EmployeeName, int DepartmentNo)
        {
            employeeNo = EmployeeNo;
            employeeName = EmployeeName;
            departmentNo = DepartmentNo;
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

        public string EmployeeName
        {
            get
            {
                return employeeName;
            }

            set
            {
                employeeName = value;
            }
        }

        public int DepartmentNo
        {
            get
            {
                return departmentNo;
            }

            set
            {
                departmentNo = value;
            }
        }
    }
}
