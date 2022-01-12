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
            c.ContactForename = db.Reader.GetString(1);
            c.ContactSurname = db.Reader.GetString(2);
            c.BusinessName = db.Reader.GetString(3);
            c.HouseNo = db.Reader.GetInt32(4);
            c.StreetName = db.Reader.GetString(5);
            c.TownName = db.Reader.GetString(6);
            c.PostCode = db.Reader.GetString(7);
            c.County = db.Reader.GetString(8);
            c.ContactPhoneNo = db.Reader.GetString(9);
            c.ContactEmail = db.Reader.GetString(10);
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

        //public List<string> GetAllClientNames()
        //{
        //    //string clientID, BusinessName;

        //    string sqlCmd = "Select ClientID, BusinessName FROM Client;";
        //    db.Cmd = db.Conn.CreateCommand();
        //    db.Cmd.CommandText = sqlCmd;
        //    db.Reader = db.Cmd.ExecuteReader();
        //    string results = db.Reader
        //    return results;
        //}
        public string GetAllClientNames()
        {
            //string clientID, BusinessName;

            string sqlCmd = "Select ClientID, BusinessName FROM Client;";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Reader = db.Cmd.ExecuteReader();
            string results = Convert.ToString(db.Reader);
            return results;
        }
    }
}
