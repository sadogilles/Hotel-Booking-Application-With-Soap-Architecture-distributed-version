using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agency_Mosson
{
    public class Hotel
    {
        public int Id
        {
            get;
            set;
        } 
        public String Name
        {
            get;
            set;
        }

        public String Address
        {
            get;
            set;
        }

        public String Town
        {
            get;
            set;
        }
        public String Country
        {
            get;
            set;

        }

        public String PhoneNumber
        {
            get;
            set;
        } 

        public int Rating
        {
            get;
            set;
        }


        public int NumberOfRoom
        {
            get;
            set;

        }

        public int NumberOfBed
        {
            get;
            set;
        }

        public List<Room> Rooms
        {
            get;
            set;
        } = new List<Room>(); //initilisation

        public List<Offer> offers
        {
            get;
            set;
        } = new List<Offer>();
        //hotel default constructor
        public Hotel()
        {
        }
        
    }
}