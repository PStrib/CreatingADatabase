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
        private object cell;

        public OfficeHire()
        {
            InitializeComponent();
            CBoxClients.DataSource = cdbAccess.GetAllClientNames();
            PopulateRowHeadings();
        }

        private void PopulateRowHeadings()
        {
            string[] officeNames = new string[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            DGVAvailability.RowCount = 10;
            for (int i = 0; i < DGVAvailability.Rows.Count; i++)
            {
                DGVAvailability.Rows[i].HeaderCell.Value = officeNames[i];
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
            //iterate trough 
            int month = Convert.ToInt32(cmbMonth.SelectedItem);
            int year = Convert.ToInt32(CBoxYear.SelectedItem);
            List<string> monthyears = new List<String>();
            for(int i = 0; i < 24; i++)
            {
                if (month == 13)
                {
                    month = 1;
                    year += 1;
                }
                monthyears.Add(month + "/" + year);
                DGVAvailability.Columns[i] = monthyears;
                month++;
            }
            foreach (DataGridViewRow row in DGVAvailability.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    //int officeNum =
                    //int month = 
                    //int year =
                }
            }
        }

        private void DGVAvailabilityCellClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Drawing.Color c = DGVAvailability.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor;
            if (c == Color.Empty)
            {
                DGVAvailability.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Blue;
            }

            else if (c == Color.Blue)
            {
                DGVAvailability.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
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
