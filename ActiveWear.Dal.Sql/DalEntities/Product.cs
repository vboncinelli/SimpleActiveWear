﻿namespace ActiveWear.Dal.Sql.Entities
{
    public class Product: BaseDalEntity
    {

        public string Name { get; set; } = null!;

        public Season Season { get; set; }
        
        public string? ImageUri { get; set; }

        public string Description { get; set; } = null!;

        public Brand? ProductBrand { get; set; }

        public int BrandId { get; set; }

        public int CategoryId { get; set; }

        public Category? ProductCategory { get; set; }

        public decimal Price { get; set; }
    }
}