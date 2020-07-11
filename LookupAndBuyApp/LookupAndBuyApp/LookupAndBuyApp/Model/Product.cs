
using System;
using System.Collections.Generic;
using System.Text;

namespace LookupAndBuyApp.Model
{
    public class Product
    {
        public string Barcode { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime RegistrationTime { get; set; } 
        public Store StoreHost { get; set; }
    }
}
