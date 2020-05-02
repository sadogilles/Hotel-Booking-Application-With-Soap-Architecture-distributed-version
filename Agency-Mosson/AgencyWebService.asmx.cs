using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Agency_Mosson
{
    /// <summary>
    /// Summary description for AgencyWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AgencyWebService : System.Web.Services.WebService
    {
        AgencyController agencyControl = new AgencyController();


        [WebMethod]
        public List<Hotel> getHotel()
        {
            return agencyControl.getHotel();
        }

        //[WebMethod]
        //public String getBookingInformaton(int _hotel_id, int _room_id, int client_id, String _firstName, String _lastName, String _cardInfo)
        //{
        //    return agencyControl.Booking(_hotel_id, _room_id, client_id, _firstName, _lastName, _cardInfo);
        //}

        [WebMethod]

        public List<Room> getRoomFromHotel(String _hotelName)
        {
            return agencyControl.getRoomFromHotel(_hotelName);

        }

        [WebMethod]
        public List<Hotel> searchhotel(string _town, int _minPrice, int _maxPrice, int _numberofStars)
        {

            return agencyControl.hotelSearch(_town, _minPrice, _maxPrice, _numberofStars);

        }

    }
}
