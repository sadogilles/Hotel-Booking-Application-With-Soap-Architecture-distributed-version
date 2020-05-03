using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Collisee
{
    public class HotelController
    {


        public Hotel Hotel
        {
            get;
            set;
        }

        public HotelController()
        {
            Hotel = new Hotel();
        }

        public Hotel getHotel()
        {
            return Hotel;
        }

        public List<Offer> doBooking(String _userName, String _password)
        {

            foreach (AgencyInfo login in Hotel.Agencies)
            {

                if (login.UserName.ToLower().Equals(_userName.ToLower()) && login.Password.ToLower().Equals(_password.ToLower()))
                {
                    return Hotel.Offers;
                }
                else
                {
                    return null;
                }

            }

            return null;
        }


        public String doBooking(String _userName, String _password, int _offer_id)
        {

            foreach (AgencyInfo login in Hotel.Agencies)
            {

                if (login.UserName.ToLower().Equals(_userName.ToLower()) && login.Password.ToLower().Equals(_password.ToLower()))
                {
                    //check the offer
                    // off = Hotel.Offers.Where(o => o.Id == _offer_id).FirstOrDefault();

                    return "Hotel Collisee Booking: Success";

                }
                else
                {
                    //return Hotel.Offers.FirstOrDefault();
                    return "Hotel Collisee Booking: Error Occured during Login";
                }

            }
            return null; // return nothing
        }



    }
}