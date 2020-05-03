using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;

namespace Hotel_Ibis
{
    public class HotelController
    {

       
        public Hotel Hotel {
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

        public List<Offer> getOffer(String _userName, String _password, String _startReservationDate, String _endReservationDate, int _numberOfPersonToHost)
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
        

        public String doBooking(String _userName,String _password, int _offer_id)
        {

            foreach (AgencyInfo login in Hotel.Agencies)
            {

                if (login.UserName.ToLower().Equals(_userName.ToLower()) && login.Password.ToLower().Equals(_password.ToLower()))
                {
                    //return a success message
                    return "Hotel Ibis Booking: Success";

                }
                else
                {
                    return "Hotel Ibis : Error while Login";
                }

            }
            return null; //return nothing
        }

        

    }
}