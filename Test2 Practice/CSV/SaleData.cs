﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV
{
    public class SaleData
    {
        public DateTime Transaction_date { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public string Payment_Type { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Account_Created { get; set; }
        public string Last_Login { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public SaleData()
        {
            Transaction_date = DateTime.Now;
            Product = string.Empty;
            Price = 0;
            Payment_Type = string.Empty;
            Name = string.Empty;
            City = string.Empty;
            State = string.Empty;
            Country = string.Empty;
            Account_Created = string.Empty;
            Last_Login = string.Empty;
            Latitude = string.Empty;
            Longitude = string.Empty;
        }

        public override string ToString()
        {
            return $"{Product}, costed {Price.ToString("C")}, and was bought by {Name} using {Payment_Type}";
        }
    }
}
