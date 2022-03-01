using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        ClientDBAccess cDBAccess = new ClientDBAccess(MainApp.Db);
        Reservation_RoomDBAccess rdbAccess = new Reservation_RoomDBAccess(MainApp.Db);

        public OfficeHire()
        {
            InitializeComponent();
            CBoxClients.DataSource = cDBAccess.GetAllClientNames();
        }

        private void PopulateColumnHeadings()
        {
            string[] officeNames = new string[10] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "11" };
            DGVAvailability.ColumnCount = 10;
            for (int i = 0; i < DGVAvailability.Columns.Count; i++)
            {
                DataGridViewColumn column = DGVAvailability.Columns[i];
                column.HeaderCell.Value = officeNames[i];
                column.Width = 26;
            }
            DGVAvailability.RowHeadersWidth = 78;
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
            PopulateColumnHeadings();
            DGVAvailability.Rows.Clear();
            //iterate through and fill the column headers
            int yearSelected = Convert.ToInt32(CBoxYear.SelectedItem);

            int month = 1; //Month is always January
            int year = yearSelected;
            for(int i = 0; i < 24; i++)
            {
                if (month == 13)
                {
                    month = 1;
                    year += 1;
                }

                DGVAvailability.Rows.Add();
                // TODO: make this be a DateTime
                DGVAvailability.Rows[i].HeaderCell.Value = $"{month}/{year}";
                month++;
            }

            DateTime viewStart = new DateTime(yearSelected, 01, 01);
            DateTime viewEnd = viewStart.AddYears(2);
            List<RoomBooking> bookings = rdbAccess.GetDateRange(viewStart, viewEnd);


            foreach (DataGridViewRow row in DGVAvailability.Rows)
            {
                foreach (DataGridViewColumn column in DGVAvailability.Columns)
                {
                    foreach (RoomBooking b in bookings)
                    {
                        var dateString = row.HeaderCell.Value as string;
                        var a = dateString.Split('/');
                        var m = Convert.ToInt32(a[0]);
                        var y = Convert.ToInt32(a[1]);
                        var rowDate = new DateTime(y, m, 1);
                        if (Convert.ToInt32(column.HeaderCell.Value) == b.office && (rowDate <= b.endDate && rowDate >=b.startDate ))
                        {
                            DataGridViewCell dataGridViewCell = DGVAvailability[column.Index, row.Index];
                            dataGridViewCell.Style.BackColor = Color.Red;
                            dataGridViewCell.ReadOnly = true;
                        }
                    }
                }
            }
            DGVAvailability.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            string clientBox = CBoxClients.Text;
            string[] parts = clientBox.Split(':');

            rdbAccess.AddNewBooking(Convert.ToInt16(parts[0]), DTPStartDate.Value, DTPEndDate.Value, Convert.ToInt16(CBoxRoomNo.Text), TBStaffName.Text);
        }
        //The method Listbox.FindString() may be helpful
    }
}
