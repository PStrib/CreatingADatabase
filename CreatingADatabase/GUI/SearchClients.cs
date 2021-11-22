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
    public partial class SearchClients : Form
    {
        private Database db = MainApp.Db;
        ClientDBAccess cdbAccess = new ClientDBAccess(MainApp.Db);
        public SearchClients()
        {
            InitializeComponent();
        }

        private void btnSearchClients_Click(object sender, EventArgs e)
        {
            ClientDBAccess cDBAccess = new ClientDBAccess(Program.Db);
            DataTable dt = new DataTable();
            int typeCheck;

            if (!Int32.TryParse(txtClientSearch.Text, out typeCheck))
            {
                cDBAccess.GetClientsWithName(txtClientSearch.Text);
                dt = cDBAccess.GetClientDataTable();
                ClientDatagrid.DataSource = dt;
            }
            else
            {
                cDBAccess.GetClientsWithID(Convert.ToInt32(txtClientSearch.Text));
                dt = cDBAccess.GetClientDataTable();
                ClientDatagrid.DataSource = dt;
            }
        }

        private void ClientDatagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Method to allow the user to edit client details from the datagridview.
            ClientDBAccess cDBAccess = new ClientDBAccess(Program.Db);
            var rowSelected = e.RowIndex;
            var columnSelected = e.ColumnIndex+1;
            bool valid = true;
            ClientDBAccess c = new ClientDBAccess(db);
            Client client = new Client();

            var senderDGV = (DataGridView)sender;

            //Try-catch for setting the client's contact forename
            try
            {
                client.ContactForename = Convert.ToString(senderDGV[rowSelected, 0]);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

            //Try-catch for setting client's contact Surname
            try
            {
                client.ContactSurname = Convert.ToString(senderDGV[rowSelected, 1]);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

            //Try-catch for setting client's contact phone no.
            try
            {
                client.ContactPhoneNo = Convert.ToString(senderDGV[rowSelected, 2]);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

            //try-catch for setting the client's contact email
            try
            {
                client.ContactEmail = Convert.ToString(senderDGV[rowSelected, 3]);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

            //Try-catch for setting the client's business name
            try
            {
                client.BusinessName = Convert.ToString(senderDGV[rowSelected, 4]);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

            //Try-catch for setting the client's house number
            try
            {
                client.HouseNo = Convert.ToInt16(senderDGV[rowSelected, 5]);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

            //Try-catch for setting the client's street name
            try
            {
                client.StreetName = Convert.ToString(senderDGV[rowSelected, 6]);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

            //Try-catch for setting the client's town name
            try
            {
                client.TownName = Convert.ToString(senderDGV[rowSelected, 7]);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

            //Try-catch for setting the client's Postcode
            try
            {
                client.PostCode = Convert.ToString(senderDGV[rowSelected, 8]);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

            //Try-catch for setting the client's county
            try
            {
                client.County = Convert.ToString(senderDGV[rowSelected, 9]);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

            if (valid) //If the form successfully completes all required text validation
            {
                //ClientDBAccess cDBAccess = new ClientDBAccess(db);
                c.UpdateClient(client);
                MessageBox.Show("Client Information Updated!");
            }
        }
    }
}
