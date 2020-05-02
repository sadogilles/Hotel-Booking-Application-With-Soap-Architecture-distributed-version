using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Renarviere
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


        public Offer doBooking(String _userName, String _password, int _offer_id)
        {

            foreach (AgencyInfo login in Hotel.Agencies)
            {

                if (login.UserName.ToLower().Equals(_userName.ToLower()) && login.Password.ToLower().Equals(_password.ToLower()))
                {
                    //check the offer
                    Offer off = Hotel.Offers.Where(o => o.Id == _offer_id).FirstOrDefault();
                    return off;

                }
                else
                {
                    return Hotel.Offers.FirstOrDefault();
                }

            }
            return null; // no offer
        }



    }
}