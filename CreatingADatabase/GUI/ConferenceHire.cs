using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            toolTip1.SetToolTip(lblHelpBox, "If you want to make an all day booking,\nsimply make half the booking with the 'is morning?' checkbox\nthen make the other half of your booking without it checked.");
        }
        private void PopulateColumnHeadings()
        {
            DGVAvailability.ColumnCount = 2;

            DGVAvailability.Columns[0].HeaderCell.Value = "AM";
            DGVAvailability.Columns[0].Width = 30;

            DGVAvailability.Columns[1].HeaderCell.Value = "PM";
            DGVAvailability.Columns[1].Width = 30;

            DGVAvailability.RowHeadersWidth = 100;//--------Adjust row header size
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
                    bool isMorning = column.HeaderCell.Value as String == "AM";
                    foreach (ConferenceRoomBooking b in bookings)
                    {
                        var dateString = row.HeaderCell.Value as string;
                        var rowDate = DateTime.ParseExact(dateString, "dd'/'MM'/'yyyy", CultureInfo.InvariantCulture);
                       
                        if (rowDate <= b.endDate.Date && rowDate >= b.startDate.Date && b.isMorning==isMorning)
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

            //if()

            if (!rdbAccess.AddNewConferenceBooking(Convert.ToInt16(parts[0]), DTPStartDate.Value,
                            DTPStartDate.Value.AddDays(Convert.ToInt16(numBoxDays.Value)),
                            txtCateringReqs.Text,
                            Convert.ToInt16(numBoxAttendees.Value),
                            ChBoxIsMorning.Checked,
                            TBStaffName.Text))
            {
                MessageBox.Show("Booking clashes detected");
                return;
            }

            MessageBox.Show("Booking added!");
            btnSearch_Click(sender, e);
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            CBoxClients.Text = "";
            DTPStartDate.Value = DateTime.Today;
            numBoxDays.Value = 1;
            txtCateringReqs.Text = "";
            numBoxAttendees.Value = 1;
            ChBoxIsMorning.Checked = false;
        }
    }
}
