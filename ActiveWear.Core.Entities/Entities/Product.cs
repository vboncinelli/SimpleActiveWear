﻿namespace ActiveWear.Core.Entities
{
    public class Product: BaseEntity
    {
        public Product(
            string name,
            string description,
            int brandId,
            int categoryId,
            decimal price,
            Season season = Season.AllSeason,
            string? imageUri = null
            ) 
        {
            Name = name;
            Description = description;
            BrandId = brandId;
            CategoryId = categoryId;
            Price = price;
            Season = season;
            ImageUri = imageUri;
        }
        public string Name { get; private set; }
        public Season Season { get; private set; }
        public string? ImageUri { get; private set; }
        public string Description { get; private set; }
        public Brand? ProductBrand { get; private set; }
        public int BrandId { get; private set; }
        public int CategoryId { get; private set; }
        public Category? ProductCategory { get; private set; }
        public decimal Price { get; private set; }

        public void UpdatePrice (decimal newPrice) {
            if( newPrice < 0 )
            {
                throw new ArgumentException("Il prezzo non può essere negativo");
            }

            if( newPrice > 10_000 ) {
                throw new ArgumentException("Il prezzo ha superato il limite");
            }

            Price = newPrice;
        }

        public void UpdateDetails (string name,  string description, string imageUri)
        {
            if(string.IsNullOrWhiteSpace(name)) { 
                throw new ArgumentNullException("Inserisci un nome per il prodotto");
            } 

            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentNullException("Inserisci una descrizione per il prodotto");
            }

            if (string.IsNullOrWhiteSpace(imageUri))
            {
                throw new ArgumentNullException("Inserisci url per l'immagine del prodotto");
            }
        }
    }
}