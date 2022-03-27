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
    public partial class AddClient : Form
    {
        private Database db = MainApp.Db;
        public AddClient()
        {
            InitializeComponent();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            bool valid = true;
            ClientDBAccess c = new ClientDBAccess(db);
            Client client = new Client();
            
            //Try-catch for setting the client's contact forename
            try
            {
                client.ContactForename = txtContactForename.Text;
            }
            catch (Exception ex) { lblErrors.Text+=ex.Message+"\n"; valid = false; }

            //Try-catch for setting client's contact Surname
            try
            {
                client.ContactSurname = txtContactSurname.Text;
            }
            catch (Exception ex) { lblErrors.Text += ex.Message + "\n"; valid = false; }

            //Try-catch for setting client's contact phone no.
            try
            {
                client.ContactPhoneNo = txtContactNo.Text;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

            //try-catch for setting the client's contact email
            try
            {
                client.ContactEmail = txtContactEmail.Text;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

            //Try-catch for setting the client's business name
            try
            {
                client.BusinessName = txtBusinessName.Text;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

            //Try-catch for setting the client's house number
            try
            {
                client.HouseNo = Convert.ToInt32(txtHouseNo.Text);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

            //Try-catch for setting the client's street name
            try
            {
                client.StreetName = txtStreetName.Text;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

            //Try-catch for setting the client's town name
            try
            {
                client.TownName = txtTownName.Text;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

            //Try-catch for setting the client's Postcode
            try
            {
                client.PostCode = txtPostcode.Text;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

            //Try-catch for setting the client's county
            try
            {
                client.County = txtCounty.Text;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

            if (valid) //If the form successfully completes all required text validation
            {
                ClientDBAccess cDBAccess = new ClientDBAccess(db);
                c.AddNewClient(client);
                MessageBox.Show("Client Added!");
                ClearAllFields();
                this.Hide();
                MainApp mainApp = new MainApp();
                mainApp.ShowDialog();
                this.Close();
                this.Dispose();
            }
        }

        private void ClearAllFields()
        {
            txtContactForename.Text = "";
            txtContactSurname.Text = "";
            txtContactNo.Text = "";
            txtContactEmail.Text = "";
            txtBusinessName.Text = "";
            txtHouseNo.Text = "";
            txtStreetName.Text = "";
            txtTownName.Text = "";
            txtPostcode.Text = "";
            txtCounty.Text = "";
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
            //Closes this form and opens the main menu
        {
            this.Hide();
            MainApp mainApp = new MainApp();
            mainApp.ShowDialog();
            this.Close();
            this.Dispose();
        }
    }
}
