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

namespace CreatingADatabase.GUI
{
    public partial class SearchClients : Form
    {
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

            int rowSelected=sender.

        }
    }
}
