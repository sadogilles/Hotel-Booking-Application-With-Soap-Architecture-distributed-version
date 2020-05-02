using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Hotel_Collisee
{
    /// <summary>
    /// Summary description for HotelWebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class HotelWebService1 : System.Web.Services.WebService
    {

        HotelController hotelControl = new HotelController();


        [WebMethod]
        public Hotel getHotel()
        {
            return hotelControl.getHotel();
        }

        [WebMethod]
        public List<Offer> getAgencyLogin(String _userName, String _password)
        {
            //return hotelControl.getOffer(int offer_id, String _numberOfBed,int _price);
            return hotelControl.doBooking(_userName, _password);
        }
    }
}
