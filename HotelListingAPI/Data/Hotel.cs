﻿using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListingAPI.Data
{
    public class Hotel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }
        
        [ForeignKey(nameof(CountryID))]
        public int CountryID { get; set; }
        public Country Country { get; set; }
    }
}
