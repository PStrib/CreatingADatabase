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
                column.Width = 26; //Play around with this
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
            //iterate through and fill the column headers
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
                //DGVAvailability.Rows.Add(monthyears[i], monthyears[i]);
                DGVAvailability.Rows.Add();
                DGVAvailability.Rows[i].HeaderCell.Value = monthyears[i];
                month++;
            }
            foreach (DataGridViewRow row in DGVAvailability.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    int officeNum = DGVAvailability.CurrentCell.RowIndex + 2; // To be continued
                }
            }
            //var test=rdbAccess.GetDateRange(Convert.ToString(month),Convert.ToString(year));
            SqlDataReader reader = rdbAccess.GetDateRange(Convert.ToString(month), Convert.ToString(year));
            string test="";

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    test += reader.GetString(0);
                }
            }
            MessageBox.Show(test);
        }

        private void DGVAvailabilityCellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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

            catch
            {
                MessageBox.Show("You can't select a column or row heading");
            }

        }
        //The method Listbox.FindString() may be helpful
    }
}
