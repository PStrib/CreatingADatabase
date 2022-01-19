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
    public partial class OfficeHire : Form
    {
        private Database db = MainApp.Db;
        ClientDBAccess cdbAccess = new ClientDBAccess(MainApp.Db);
        public OfficeHire()
        {
            InitializeComponent();
            CBoxClients.DataSource = cdbAccess.GetAllClientNames();
            PopulateRowHeadings();
        }

        private void PopulateRowHeadings()
        {
            string[] officeNames = new string[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            dataGridView1.RowCount = 10;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = officeNames[i];
            }
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainApp mainApp = new MainApp();
            mainApp.ShowDialog();
            this.Close();
            this.Dispose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    int officeNum =//
                    int month = 
                    int year
                }
            }
        }
        //The method Listbox.FindString() may be helpful
//        select roomid, month(startdate), year(startdate), month(enddate), year(enddate)
//from[reservation - room]
//where month(startdate)>=1 
//and year(startdate)=2022
//and month(enddate)<=6
//and year(enddate)=2022


    }
}
