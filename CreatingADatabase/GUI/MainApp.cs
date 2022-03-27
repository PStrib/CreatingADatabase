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

        private void btnAddClient_Click(object sender, EventArgs e)
            //Button that opens the add client form
        {
            this.Hide();
            AddClient addClient = new AddClient();
            addClient.ShowDialog();
            this.Close();
            this.Dispose();
        }

        private void btnSearchEdit_Click(object sender, EventArgs e)
            //Button that opens the search/edit form
        {
            this.Hide();
            SearchClients searchClients = new SearchClients();
            searchClients.ShowDialog();
            this.Close();
            this.Dispose();
        }

        private void btnBooking_Click(object sender, EventArgs e)
            //Button that opens the office hire form
        {
            this.Hide();
            OfficeHire officeHire = new OfficeHire();
            officeHire.ShowDialog();
            this.Close();
            this.Dispose();
        }


        private void btnConferenceBooking_Click(object sender, EventArgs e)
            //Button that opens the conference hire form
        {
            this.Hide();
            ConferenceHire conferenceHire = new ConferenceHire();
            conferenceHire.ShowDialog();
            this.Close();
            this.Dispose();
        }
    }
}
