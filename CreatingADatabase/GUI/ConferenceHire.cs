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
    public partial class ConferenceHire : Form
    {
        ClientDBAccess cDBAccess = new ClientDBAccess(MainApp.Db);
        Reservation_RoomDBAccess rdbAccess = new Reservation_RoomDBAccess(MainApp.Db);
        public ConferenceHire()
        {
            InitializeComponent();
            CBoxClients.DataSource = cDBAccess.GetAllClientNames();
        }
        private void PopulateColumnHeadings()
        {
            string[] officeNames = new string[3] { "Date:", "AM", "PM" };
            DGVAvailability.ColumnCount = 3;
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
            int yearSelected = DTPViewStart.Value.Year;

            int day = DTPViewStart.Value.Day;
            int month = DTPViewStart.Value.Month;
            int year = yearSelected;

            DateTime viewStart = DTPViewStart.Value;
            DateTime viewEnd = viewStart.AddMonths(2);
            

            int i = 0;
            for (DateTime rowDate = viewStart; rowDate <=viewEnd; rowDate=rowDate.AddDays(1))
            {
                DGVAvailability.Rows.Add();
                // TODO: make this be a DateTime
                DGVAvailability.Rows[i].HeaderCell.Value = $"{rowDate:dd'/'MM'/'yyyy}";
                i++;
            }

            List<ConferenceRoomBooking> bookings = rdbAccess.GetConferenceDateRange(viewStart, viewEnd);


            foreach (DataGridViewRow row in DGVAvailability.Rows)
            {
                foreach (DataGridViewColumn column in DGVAvailability.Columns)
                {
                    foreach (ConferenceRoomBooking b in bookings)
                    {
                        var dateString = row.HeaderCell.Value as string;
                        var a = dateString.Split('/');
                        var d = Convert.ToInt32(a[0]);
                        var m = Convert.ToInt32(a[1]);
                        var y = Convert.ToInt32(a[2]);

                        var rowDate = new DateTime(y, m, d);
                        if ((rowDate <= b.endDate.Date && rowDate >= b.startDate.Date))
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

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            string clientBox = CBoxClients.Text;
            string[] parts = clientBox.Split(':');

            if (!rdbAccess.AddNewConferenceBooking(Convert.ToInt16(parts[0]), DTPStartDate.Value,
                            DTPStartDate.Value.AddMonths(Convert.ToInt16(numBoxMonths.Value)),
                             TBStaffName.Text))
            {
                MessageBox.Show("Booking clashes detected");
                return;
            }

            MessageBox.Show("Booking added!");
            //CBoxClients.Text = "";
            //TBStaffName.Text = "";
            //DTPStartDate.Value = DateTime.Today;
            //numBoxMonths.Value = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
