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
        }

        private void PopulateColumnHeadings()
        {
            string[] officeNames = new string[10] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "11" };
            DGVAvailability.ColumnCount = 10;
            for (int i = 0; i < DGVAvailability.Columns.Count; i++)
            {
                DGVAvailability.Columns[i].HeaderCell.Value = officeNames[i];
            }
            DGVAvailability.RowHeadersWidth = 100;
            
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
                    int officeNum = DGVAvailability.CurrentCell.RowIndex + 2;
                    int monthSelected = DGVAvailability.CurrentCell.ColumnIndex;
                    //int yearSelected =
                }
            }
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
