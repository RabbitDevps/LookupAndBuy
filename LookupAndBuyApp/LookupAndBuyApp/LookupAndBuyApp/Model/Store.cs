using System;
using System.Collections.Generic;
using System.Text;

namespace LookupAndBuyApp.Model
{
    public class Store
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime RegistrationTS { get; set; }

        public Store(string name, string description, string location)
        {
            Name = name;
            Description = description;
            Location = location;
            RegistrationTS = DateTime.Now;
        }
        public Store()
        {
            Name = "";
            Description = "";
            Location = "";
            RegistrationTS = DateTime.Now;
        }
    }
}
