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
        ClientDBAccess cDBAccess = new ClientDBAccess(MainApp.Db);
        public SearchClients()
        {
            InitializeComponent();
        }

        private void btnSearchClients_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            int typeCheck;
            ClientDatagrid.Columns.Clear();

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

            ClientDatagrid.Columns[0].ReadOnly = true;
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Update Client";
            col.Name = "btnUpdateClient";
            ClientDatagrid.Columns.Add(col);
        }

        private void ClientDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderDGV = (DataGridView)sender;
            if (senderDGV.Columns[e.ColumnIndex].Name == "btnUpdateClient")
            {
                //Method to allow the user to edit client details from the datagridview.
                var rowSelected = e.RowIndex;
                bool valid = true;
                Client client = new Client();

                client.ClientID = Convert.ToInt32(senderDGV[0, rowSelected].Value);

                //Try-catch for setting the client's contact forename
                try
                {
                    client.ContactForename = Convert.ToString(senderDGV[1, rowSelected].Value);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

                //Try-catch for setting client's contact Surname
                try
                {
                    client.ContactSurname = Convert.ToString(senderDGV[2, rowSelected].Value);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

                //Try-catch for setting the client's business name
                try
                {
                    client.BusinessName = Convert.ToString(senderDGV[3, rowSelected].Value);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

                //Try-catch for setting the client's house number
                try
                {
                    client.HouseNo = Convert.ToInt16(senderDGV[4, rowSelected].Value);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

                //Try-catch for setting the client's street name
                try
                {
                    client.StreetName = Convert.ToString(senderDGV[5, rowSelected].Value);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

                //Try-catch for setting the client's town name
                try
                {
                    client.TownName = Convert.ToString(senderDGV[6, rowSelected].Value);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

                //Try-catch for setting the client's Postcode
                try
                {
                    client.PostCode = Convert.ToString(senderDGV[7, rowSelected].Value);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

                //Try-catch for setting the client's county
                try
                {
                    client.County = Convert.ToString(senderDGV[8, rowSelected].Value);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

                //Try-catch for setting client's contact phone no.
                try
                {
                    client.ContactPhoneNo = Convert.ToString(senderDGV[9, rowSelected].Value);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

                //try-catch for setting the client's contact email
                try
                {
                    client.ContactEmail = Convert.ToString(senderDGV[10, rowSelected].Value);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

                if (valid) //If the form successfully completes all required text validation
                {
                    try
                    {
                        //ClientDBAccess cDBAccess = new ClientDBAccess(db);
                        cDBAccess.UpdateClient(client);
                        MessageBox.Show("Client Information Updated!");
                    }
                    catch
                    {
                        MessageBox.Show("Oops\nLooks like there's a restricted character in one of your fields\n(Usually a comma)");
                    }
                }
            }
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
