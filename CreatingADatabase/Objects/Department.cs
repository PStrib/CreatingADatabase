using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingADatabase.Objects
{
    class Department
    {
        private int departmentNo;
        private string departmentName;

        public Department()
        { }

        public Department(int DepartmentNo, string DepartmentName)
        {
            departmentNo = DepartmentNo;
            departmentName = DepartmentName;
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

        public string DepartmentName
        {
            get
            {
                return departmentName;
            }

            set
            {
                departmentName = value;
            }
        }

        
       
    }
}
