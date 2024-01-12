﻿namespace ActiveWear.Dal.Sql.Entities
{
    public class Address
    { 
        public string Street { get; set; } = null!;

        public string City { get; set; } = null!;
        
        public string StateOrProvince { get; set; } = null!;
        
        public string PostalCode { get; set; } = null!;
        
        public string Country { get; set; } = null!;
    }
}
