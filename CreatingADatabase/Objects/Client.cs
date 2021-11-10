using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingADatabase.Objects
{
    class Client
    {
        private int clientID;
        private string contactForename;
        private string contactSurname;
        private string businessName;
        private int houseNo;
        private string streetName;
        private string townName;
        private string postCode;
        private string county;
        private string contactPhoneNo;
        private string contactEmail;

        public Client()
        { }

        public Client(int clientID, string contactForename, string contactSurname, string businessName, int houseNo, string streetName, string townName, string postCode, string county, string contactPhoneNo, string contactEmail)
        {
            clientID = ClientID;
            contactForename = ContactForename;
            contactSurname = ContactSurname;
            businessName = BusinessName;
            houseNo = HouseNo;
            streetName = StreetName;
            townName = TownName;
            postCode = PostCode;
            county = County;
            contactPhoneNo = ContactPhoneNo;
            contactEmail = ContactEmail;
        }

        public int ClientID
        {
            get
            {
                return clientID;
            }

            set
            {
                clientID = value;
            }
        }

        public string ContactForename
        {
            get
            {
                return contactForename;
            }
            set
            {
                contactForename = value;
            }
        }
        public string ContactSurname
        {
            get
            {
                return contactSurname;
            }
            set
            {
                contactSurname = value;
            }
        }
        public string BusinessName
        {
            get
            {
                return businessName;
            }
            set
            {
                businessName = value;
            }
        }
        public int HouseNo
        {
            get
            {
                return houseNo;
            }
            set
            {
                houseNo = value;
            }
        }

        public string StreetName
        {
            get
            {
                return streetName;
            }
            set
            {
                streetName = value;
            }
        }

        public string TownName
        {
            get
            {
                return townName;
            }
            set
            {
                townName = value;
            }
        }

        public string PostCode
        {
            get
            {
                return postCode;
            }
            set
            {
                postCode = value;
            }
        }
        public string County
        {
            get
            {
                return county;
            }
            set
            {
                county = value;
            }
        }
        public string ContactPhoneNo
        {
            get
            {
                return ContactPhoneNo;
            }
            set
            {
                contactPhoneNo = value;
            }
        }
        public string ContactEmail
        {
            get
            {
                return contactEmail;
            }
            set
            {
                contactEmail = value;
            }
        }
    }
}

