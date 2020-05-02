﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Renarviere
{
    public class Hotel
    {
        public int Id
        {
            get;
            set;
        } = 3;
        public String Name
        {
            get;
            set;
        } = "Renarviere";

        public String Address
        {
            get;
            set;
        } = "80 rue  Avenir de la Justice";

        public String Town
        {
            get;
            set;
        } = "Montpellier";
        public String Country
        {
            get;
            set;

        } = "France";

        public String PhoneNumber
        {
            get;
            set;

        } = "0658967458";

        public int Rating
        {
            get;
            set;
        } = 4;


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

        public List<Offer> Offers
        {
            get;
            set;
        } = new List<Offer>();

        public List<AgencyInfo> Agencies
        {
            get;
            set;

        } = new List<AgencyInfo>();

        public Hotel()
        {

            //rooms of the hotel
            Rooms.Add(new Room(1, 100, 4, "single")); //parameters: id, price, number of bed , capacity
            Rooms.Add(new Room(2, 50, 4, "double"));
            Rooms.Add(new Room(3, 10, 3, "quad"));

            //number of rooms in the hotel
            NumberOfRoom = Rooms.Count;

            //number of bed in hotel
            foreach (Room r in Rooms)
            {
                NumberOfBed += r.NumberOfBed;

            }

            //set the number of rooms
            NumberOfRoom = Rooms.Count;

            //offers in the hotel

            Offers.Add(new Offer(1, 3, "20/10/20", 10));


            Offers.Add(new Offer(2, 4, "20/9/20", 8));

            //list of agencies in the hotel
            Agencies.Add(new AgencyInfo("mosson", "mosson2020"));

        }

    }
}