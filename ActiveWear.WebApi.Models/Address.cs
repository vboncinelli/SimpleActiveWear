using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveWear.WebApi.Models
{
    public class Address
    {
        //TODO: attributi

        public string Street { get; set; }

        public string City { get; set; }

        public string StateOrProvince { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }
    }
}
