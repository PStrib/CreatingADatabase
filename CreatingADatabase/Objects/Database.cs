using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CreatingADatabase.Objects
{
    public class Database
    {
        private SqlCommand cmd;
        private SqlConnection conn;
        private SqlDataReader reader;

        public Database()
        { }

        public SqlCommand Cmd
        {
            get
            {
                return cmd;
            }

            set
            {
                cmd = value;
            }
        }

        public SqlConnection Conn
        {
            get
            {
                return conn;
            }

            set
            {
                conn = value;
            }
        }

        public SqlDataReader Reader
        {
            get
            {
                return reader;
            }

            set
            {
                reader = value;
            }
        }

        public bool Connect()
        {
            SqlConnectionStringBuilder ScStrBuild = new SqlConnectionStringBuilder();
            ScStrBuild.DataSource = "(LocalDB)\\mssqllocaldb";
            ScStrBuild.AttachDBFilename = "|DataDirectory|ProjectDatabase.mdf";
            ScStrBuild.IntegratedSecurity = true;
            conn = new SqlConnection(ScStrBuild.ToString());
            try
            {
                conn.Open();
                return true;
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }


        }
    }
}
