using CreatingADatabase.DBAccess;
using CreatingADatabase.Objects;
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
    public partial class SearchForm : Form
    {
        private Database db = Program.Db;

        public SearchForm()
        {
            InitializeComponent();
            

            if (db.Connect())
            {
                initComboBox();
            }
            
            



            }

        public void initComboBox()
        {
            string[] Queries = {("Select all projects where budget is greater than 15000"),("Select all projects that M Phillips manages")};
            for (int i = 0; i < Queries.Length; i++)
            {
                queryCBox.Items.Add(Queries[i]);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            ProjectDBAccess pDBAccess = new ProjectDBAccess(db);
            DataTable dt = new DataTable();

            if (queryCBox.SelectedIndex == -1)
                MessageBox.Show("You have not selected a query.");
            else
            {
                switch (queryCBox.SelectedIndex)
                {
                    case 0:
                        {
                            pDBAccess.GetAllProjectsWithBudget(15000, 4);
                            dt = pDBAccess.GetProjectDataTable();
                            resultsDataGrid.DataSource = dt;
                            break;

                        }

                    case 1:
                        {
                            pDBAccess.GetAllProjectsWithManager("M Phillips");
                            dt = pDBAccess.GetProjectDataTable();
                            resultsDataGrid.DataSource = dt;
                            break;
                        }

                    default: label3.Text = "0";break;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProjectDBAccess pDBAccess = new ProjectDBAccess(db);
            pDBAccess.GetProjectsWithID(Convert.ToInt32(textBox1.Text));
            Project proj = pDBAccess.GetProjectObject();
            label6.Text = "Project Code: "+proj.ProjectCode.ToString()+"\nProject Name: "+proj.ProjectName+"\nManager Name: "+proj.ManagerName+"\nProject Budget: £"+proj.ProjectBudget;
            
        }
    }
}
