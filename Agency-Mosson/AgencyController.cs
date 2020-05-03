using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agency_Mosson
{
    public class AgencyController
    {

        //hotel references
        HotelColliseeServiceRef1.HotelWebService1SoapClient hotelColliseeClient;
        HotelColliseeServiceRef2.HotelWebService2SoapClient hotelColliseeclient2;

        HotelIbisServiceRef1.HotelWebServiceSoapClient hotelIbisClient;
        HotelIbisServiceRef2.HotelWebService2SoapClient hotelIbisClient2;

        //not used
       // HotelRenarviereServiceRef1.HotelWebService1SoapClient hotelRenarviereClient;
        
        
        //hotel from service reference variables
        HotelColliseeServiceRef1.Hotel hotelCol;
        HotelRenarviereServiceRef1.Hotel hotelRev;
        HotelIbisServiceRef1.Hotel hotelIbis;




        //local hotel
        Hotel ibis;
        Hotel collisee;
        Hotel renarviere;
        Hotel defaultHotel;
        List<Hotel> hotels; //local list of hotels
        List<Room> rooms;//local list of rooms
        Room room;
        Hotel hotel; //local hotel 
        List<Hotel> hotelSearched;
        List<Offer> offers;
        Offer offer;

        public AgencyController()
        {
            //service reveference object
            hotelColliseeClient = new HotelColliseeServiceRef1.HotelWebService1SoapClient();
            hotelColliseeclient2 = new HotelColliseeServiceRef2.HotelWebService2SoapClient();

            hotelIbisClient = new HotelIbisServiceRef1.HotelWebServiceSoapClient();
            hotelIbisClient2 = new HotelIbisServiceRef2.HotelWebService2SoapClient();

           // hotelRenarviereClient = new HotelRenarviereServiceRef1.HotelWebService1SoapClient();
        
            defaultHotel = new Hotel();

            //get the hotel from the service
            hotelCol = hotelColliseeClient.getHotel();
           //// hotelRev = hotelRenarviereClient.getHotel();
            hotelIbis = hotelIbisClient.getHotel();

            //local hotel object
            ibis = new Hotel();
            collisee = new Hotel();
            renarviere = new Hotel();

            hotels = new List<Hotel>();//local list of hotels
            rooms = new List<Room>();
            room = new Room();
            hotel = new Hotel();
            hotelSearched = new List<Hotel>();
            offer = new Offer();
            
           // offers = new List<Offer>();


            //setting local hotel to service reference hotel
            ibis.Id = hotelIbis.Id;
            ibis.Name = hotelIbis.Name;
            ibis.Town = hotelIbis.Town;
            ibis.Country = hotelIbis.Country;
            ibis.NumberOfRoom = hotelIbis.NumberOfRoom;
            ibis.NumberOfBed = hotelIbis.NumberOfRoom;
            ibis.Address = hotelIbis.Address;
            ibis.Rating = hotelIbis.Rating;
            ibis.PhoneNumber = hotelIbis.PhoneNumber;

            collisee.Id = hotelCol.Id;
            collisee.Name = hotelCol.Name;
            collisee.Town = hotelCol.Town;
            collisee.Country = hotelCol.Country;
            collisee.NumberOfRoom = hotelCol.NumberOfRoom;
            collisee.NumberOfBed = hotelCol.NumberOfRoom;
            collisee.Address = hotelCol.Address;
            collisee.Rating = hotelCol.Rating;
            collisee.PhoneNumber = hotelCol.PhoneNumber;


            HotelColliseeServiceRef1.Room[] roomCol = hotelCol.Rooms; //get the rooms
            HotelColliseeServiceRef1.Offer[] offersCol = hotelCol.Offers; //get the offers

            // loop through the rooms of hotel collisee
            foreach (HotelColliseeServiceRef1.Room r in roomCol)
            {
                room = new Room();
                //get the room
                room.Id = r.Id; 
                //reduction of 10% for all rooms
                room.Price =Convert.ToInt32(r.Price - (r.Price * 0.1));
                room.State = r.State;
                room.Capacity = r.Capacity;
                room.NumberOfBed = r.NumberOfBed;
                Console.WriteLine(r.Price);

                //add room to local rooms
                collisee.Rooms.Add(room);

            }

            //add collisee to list of hotel
            hotels.Add(collisee);
            // loop through the rooms of hotel collisee
            foreach (HotelColliseeServiceRef1.Offer off in offersCol)
            {
                offer = new Offer();
                //get the offer
                offer.Id = off.Id;
                offer.Price = off.Price;
                offer.NumberOfBed = off.NumberOfBed;


                //add offer to room
                collisee.offers.Add(offer);
               

            }

            

            HotelIbisServiceRef1.Room[] roomIbis = hotelIbis.Rooms;
            HotelIbisServiceRef1.Offer[] offerIbis = hotelIbis.Offers;
            // loop through the rooms of hotel ibis
            foreach (HotelIbisServiceRef1.Room r in roomIbis)
            {
                //get the room
                room = new Room();
                room.Id = r.Id;
                //reduction of 10% for all rooms
                room.Price = Convert.ToInt32(r.Price - (r.Price * 0.1)); ;
                room.State = r.State;
                room.Capacity = r.Capacity;
                room.NumberOfBed = r.NumberOfBed;

                ibis.Rooms.Add(room);

                Console.WriteLine(r.Price);

            }

            foreach (HotelIbisServiceRef1.Offer _off in offerIbis)
            {
                offer = new Offer();
                //get the offer
                offer.Id = _off.Id;
                offer.Price = _off.Price;
                offer.NumberOfBed = _off.NumberOfBed;


                //add offer to room
                ibis.offers.Add(offer);

            }

            hotels.Add(ibis);

            //get the offers -> use second web service 
            




        }

        //returns all the hotels
        public List<Hotel> getHotel()
        {
            
            return hotels;

        }

        public String doBooking(String hotelName, int roomID , String clientFirstName, String clientLastName, String clientCardInfo)
        {
            String agencyName = "mosson";
            String password = "mosson2020";
            int offerId = 1;
            String result = null;
            //check the corresponding hotel

            if (hotelName.ToLower().Equals("ibis")){
                //do the reservation
                result=hotelIbisClient2.doBooking(agencyName, password, offerId);
            

            }

            if (hotelName.ToLower().Equals("collisee"))
            {
               result =hotelColliseeclient2.doBooking(agencyName, password, offerId);

            }   

            return result;
          
        }

        public List<Room> getRoomFromHotel(String _hotelName)
        {

            //find the room given the hotel
            foreach (Hotel h in hotels)
            {

                //search hotel
                if (h.Name.ToLower().Equals(_hotelName.ToLower()))
                {
                    hotel = h;

                    foreach (Room r in hotel.Rooms)
                    {
                        rooms.Add(r);
                    }
                }



            }

            return rooms;
        }


        //simple search
        public List<Hotel> hotelSearch(String _town, int _minPrice, int _maxPrice, int _numberOfStars)
        {



            foreach (Hotel hotel in hotels)
            {
                if (hotel.Town.ToLower().Equals(_town.ToLower()) && hotel.Rating.Equals(_numberOfStars))
                {

                    foreach (Room room in hotel.Rooms)
                    {
                        if (room.Price > _minPrice && room.Price < _maxPrice)
                        {
                            //room within price exist
                            hotelSearched.Add(hotel);
                            break; //go to to next hotel

                        }
                        else
                        {
                            //do nothing 
                        }


                    }

                }

            }

            return hotelSearched;
        }
    }
}
