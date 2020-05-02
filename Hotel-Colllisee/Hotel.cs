using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Collisee
{
    public class Hotel
    {
        public int Id
        {
            get;
        } = 2;
        public String Name
        {
            get;
        } = "Collisee";

        public String Address
        {
            get;
        } = "79 rue phillipe ";

        public String Town
        {
            get;
        } = "Montpellier";
        public String Country
        {
            get;

        } = "France";

        public String PhoneNumber
        {
            get;
            set;
        } = "0628390459";

        public int Rating
        {
            get;
            set;
        } = 4;


        public int NumberOfRoom
        {
            get;

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



        public Hotel()
        {

            //rooms of the hotel
            Rooms.Add(new Room(1, 100, 4, "single")); //parameters: id, price, number of bed , capacity
            Rooms.Add(new Room(2, 50, 3, "double"));
            Rooms.Add(new Room(3, 10, 3, "quad"));

            //number of rooms in the hotel
            NumberOfRoom = Rooms.Count;

            //number of bed in hotel
            foreach (Room r in Rooms)
            {
                NumberOfBed += r.NumberOfBed;
            }
        }
    }
}