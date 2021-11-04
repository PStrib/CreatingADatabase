using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreatingADatabase.DBAccess;
using CreatingADatabase.Objects;

namespace CreatingADatabase.GUI
{
    public partial class MainApp : Form
    {
        private static Database db;
        public static Database Db { get => db; set => db = value; }
        public MainApp()
        {
            InitializeComponent();
            db = new Database();
            if (!db.Connect())
            {
                MessageBox.Show("Database connection Unsuccessful.", "Error");
            }
        }

        private void btnSearchTool_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
        }

        private void btnEditProject_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.Show();
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            AddProjectForm addProjectForm = new AddProjectForm();
            addProjectForm.Show();
        }
    }
}
