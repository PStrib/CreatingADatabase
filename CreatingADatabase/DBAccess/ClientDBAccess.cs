using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreatingADatabase.Objects;

namespace CreatingADatabase.DBAccess
{
    class ClientDBAccess
    {
        private Database db;

        public ClientDBAccess(Database _db)
        {
            db = _db;
        }

        public Client GetClientFromDataReader()
        {
            Client c = new Objects.Client();
            c.ClientID = db.Reader.GetInt32(0);
            c.BusinessName = db.Reader.GetString(1);
            return c;
        }

        public void AddNewClient(Client c)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "insert into Client (ContactForename, ContactSurname, BusinessName, HouseNo, Street, Town, PostCode, County, ContactNo, ContactEmail) values ('" + c.ContactForename + "','" + c.ContactSurname + "','" +
            c.BusinessName + "','" + c.HouseNo + "','" + c.StreetName +
            "','" + c.TownName + "','" +c.PostCode+ "','" + c.County + "','" + c.ContactPhoneNo + "','" + c.ContactEmail +"')";
            db.Cmd.ExecuteNonQuery();
        }

        public void UpdateClient(Client c)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "UPDATE Client set ContactForename = '" + c.ContactForename + "', ContactSurname = '" + c.ContactSurname + "', BusinessName = '" +
            c.BusinessName + "', HouseNo = '"+c.HouseNo+"', Street = '"+c.StreetName+"', Town = '"+c.TownName+"', PostCode = '"+c.PostCode+"'" +
            ", County = '"+c.County+"', ContactNo = '"+c.ContactPhoneNo+"', ContactEmail = '"+c.ContactEmail+"' WHERE ClientID="+c.ClientID+"";
            db.Cmd.ExecuteNonQuery();
        }

        public void GetClientsWithName(string businessName)
        {
            string sqlCmd = ("SELECT * FROM Client WHERE BusinessName LIKE '" + businessName +"%'");
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Reader = db.Cmd.ExecuteReader();
        }

        public DataTable GetClientDataTable()
        {
            DataTable dt = new DataTable();
            dt.Load(db.Reader);
            return dt;
        }
        public void GetClientsWithID(int clientNo)
        {
            string sqlCmd = "SELECT * FROM Client WHERE ClientID =" + clientNo;
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Reader = db.Cmd.ExecuteReader();           
        }

        public List<string> GetAllClientNames()
        {
            //string clientID, BusinessName;

            string sqlCmd = "Select ClientID, BusinessName FROM Client;";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Reader = db.Cmd.ExecuteReader();

            List<string> results = new List<string>();
            while (db.Reader.Read())
            {
                Client c = GetClientFromDataReader();
                results.Add($"{c.ClientID}: {c.BusinessName}");
            }
            db.Reader.Close();
            return results;
        }
    }
}
