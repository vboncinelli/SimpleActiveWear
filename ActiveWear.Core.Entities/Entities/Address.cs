using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveWear.Core.Entities
{
    public class Address
    {
        public Address(string street, string city, string stateOrProvince, string postalCode, string country)
        {
            Street = street;
            City = city;
            StateOrProvince = stateOrProvince;
            PostalCode = postalCode;
            Country = country;
        }

        public string Street { get; set; }

        public string City { get; set; }
        
        public string StateOrProvince { get; set; }
        
        public string PostalCode { get; set; }
       
        public string Country { get; set; }
    }
}
