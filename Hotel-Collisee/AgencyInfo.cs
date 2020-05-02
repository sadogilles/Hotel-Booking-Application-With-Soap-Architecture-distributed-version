using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Collisee
{
    public class AgencyInfo
    {
        public String UserName
        {
            get;
            set;
        }

        public String Password
        {
            get;
            set;
        }

        public AgencyInfo()
        {
        }


        public AgencyInfo(String _userName, String _password)
        {
            UserName = _userName;
            Password = _password;
        }

    }
}