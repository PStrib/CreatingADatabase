using CreatingADatabase.DBAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingADatabase.GUI
{
    public partial class SearchFormByName : Form
    {
        public SearchFormByName()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProjectDBAccess pDBAccess = new ProjectDBAccess(Program.Db);
            DataTable dt = new DataTable();
            int typeCheck;

            if(!Int32.TryParse(textBox1.Text, out typeCheck))
            {
                pDBAccess.GetProjectsWithName(textBox1.Text);
                dt = pDBAccess.GetProjectDataTable();
                dataGridView1.DataSource = dt;
            }
            else
            {
                pDBAccess.GetProjectsWithID(Convert.ToInt32(textBox1.Text));
                dt = pDBAccess.GetProjectDataTable();
                dataGridView1.DataSource = dt;
            }
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProjectDBAccess pDBAccess = new ProjectDBAccess(Program.Db);
            DataTable dt = new DataTable();

            int projID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            pDBAccess.GetEmployeesFromProject(projID);
            dt = pDBAccess.GetProjectDataTable();
            employeeDatagrid.DataSource = dt;

            label2.Text = ("Employee Count: " + pDBAccess.GetEmployeeCountOnProject(projID));
        }
    }
}
