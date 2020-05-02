using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Hotel_Renarviere
{
    /// <summary>
    /// Summary description for HotelWebService2
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class HotelWebService2 : System.Web.Services.WebService
    {

        HotelController hotelController = new HotelController();

        [WebMethod]
        public Offer doBooking(String _userName, String _password, int _offer_id)
        {
            return hotelController.doBooking(_userName, _password, _offer_id);

        }
    }
}
