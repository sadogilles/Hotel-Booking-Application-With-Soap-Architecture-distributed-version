using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Renarviere
{
    public class Offer
    {
        public int Id
        {
            get;
            set;
        }
        public int NumberOfBed
        {
            get;
            set;
        }
        public String DateAvailable
        {
            get;
            set;
        }
        public int Price
        {
            get;
            set;
        }
        public Offer()
        {


        }

        public Offer(int _id, int _numberOfBed, String _dateAvailable, int _price)
        {
            Id = _id;
            NumberOfBed = _numberOfBed;
            DateAvailable = _dateAvailable;
            Price = _price;

        }

    }
}