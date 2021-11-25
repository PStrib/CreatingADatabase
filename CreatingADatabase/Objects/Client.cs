using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                if (CheckPresent(value))
                    contactForename = value;
                else
                    throw new Exception("You must enter your forename or that of your company's contact person");
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
                if (CheckPresent(value))
                    contactSurname = value;
                else
                    throw new Exception("You must enter your surname or that of your company's contact person.");
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
                if (CheckPresent(value))
                    businessName = value;
                else
                    throw new Exception("You must enter your business' name./nIf you are not booking for a business, enter your surname.");
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
                if (CheckPresent(value))
                    houseNo = value;
                else
                    throw new Exception("You must enter a house number");
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
                if (CheckPresent(value))
                    streetName = value;
                else
                    throw new Exception("You must enter a street name");
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
                if (CheckPresent(value))
                    townName = value;
                else
                    throw new Exception("You must enter a town name");
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
                if (CheckPostCode(value))
                    postCode = value;
                else
                    throw new Exception("You must enter a valid postcode");
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
                if (CheckPresent(value))
                    county = value;
                else
                    throw new Exception("You must enter a county");
            }
        }
        public string ContactPhoneNo
        {
            get
            {
                return contactPhoneNo;
            }
            set
            {
                if (CheckPresent(value))
                    contactPhoneNo = value;
                else
                    throw new Exception("You must enter a valid phone number");
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
                if (CheckPresent(value))
                    contactEmail = value;
                else
                    throw new Exception("You must enter an email address");
            }
        }

        private bool CheckPresent(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return false;
            else
                return true;
        }

        private bool CheckPresent(int value)
        {
            string strvalue = Convert.ToString(value);
            if (string.IsNullOrWhiteSpace(strvalue))
                return false;
            else
                return true;
        }

        private bool CheckPhoneNo(string value)
        {
            Regex rgx = new Regex(@"\+(9[976]\d | 8[987530]\d | 6[987]\d | 5[90]\d | 42\d | 3[875]\d |
2[98654321]\d | 9[8543210] | 8[6421] | 6[6543210] | 5[87654321] |
4[987654310] | 3[9643210] | 2[70] | 7 | 1)\d{ 1,14}$");
            var match = Regex.Match(value, rgx.ToString());

            if (!match.Success)
                return false;
            else
                return true;
        }

        private bool CheckPostCode(string value)
        {
            //Copy pasted off StackOverflow
            Regex rgx = new Regex(@"^(([gG][iI][rR] {0,}0[aA]{2})|((([a-pr-uwyzA-PR-UWYZ][a-hk-yA-HK-Y]?[0-9][0-9]?)|(([a-pr-uwyzA-PR-UWYZ][0-9][a-hjkstuwA-HJKSTUW])|([a-pr-uwyzA-PR-UWYZ][a-hk-yA-HK-Y][0-9][abehmnprv-yABEHMNPRV-Y]))) {0,}[0-9][abd-hjlnp-uw-zABD-HJLNP-UW-Z]{2}))$");
            var match = Regex.Match(value, rgx.ToString());

            if (!match.Success)
                return false;
            else
                return true;
        }
    }
}

