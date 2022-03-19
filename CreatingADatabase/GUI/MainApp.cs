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

        private void btnInnerJoin_Click(object sender, EventArgs e)
        {
            InnerJoinForm innerJoinForm = new InnerJoinForm()/*(db)*/;
            innerJoinForm.Show();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddClient addClient = new AddClient();
            addClient.ShowDialog();
            this.Close();
            this.Dispose();
        }

        private void btnSearchEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchClients searchClients = new SearchClients();
            searchClients.ShowDialog();
            this.Close();
            this.Dispose();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            OfficeHire officeHire = new OfficeHire();
            officeHire.ShowDialog();
            this.Close();
            this.Dispose();
        }

        private void btnConferenceBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConferenceHire conferenceHire = new ConferenceHire();
            conferenceHire.ShowDialog();
            this.Close();
            this.Dispose();
        }
    }
}
