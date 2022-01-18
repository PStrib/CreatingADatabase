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
            //MessageBox.Show(cdbAccess.GetAllClientNames());
        }
        //The method Listbox.FindString() may be helpful


    }
}
