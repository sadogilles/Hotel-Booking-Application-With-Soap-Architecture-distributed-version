using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Agency_Mosson
{
    /// <summary>
    /// Summary description for AgencyBookingWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AgencyBookingWebService : System.Web.Services.WebService
    {
        AgencyController agencyControl = new AgencyController();
        [WebMethod]
        public List<Offer> doBooking(String _userName, String _password){ 
           return  agencyControl.doBooking(_userName, _password);
        }
    }
}
