using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingADatabase
{
    public partial class Report : Form
    {
        string clientID = "";
        public Report(string _clientID)
        {
            InitializeComponent();
            clientID = _clientID;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetBookings.DataTable1' table. You can move, or remove it, as needed.
            int clientIDNo = Convert.ToInt32(clientID);
            this.DataTable1TableAdapter.Fill(this.DataSetBookings.DataTable1, clientIDNo);

            this.reportViewer1.RefreshReport();
        }
    }
}
