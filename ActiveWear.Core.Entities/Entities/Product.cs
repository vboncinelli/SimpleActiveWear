namespace ActiveWear.Core.Entities
{
    public class Product: BaseEntity
    {
        public Product(
            string name,
            string description,
            int brandId,
            int categoryId,
            decimal price,
            string? imageUri = null,
            Brand? brand = null,
            Category? category = null) 
        {
            Name = name;
            Description = description;
            BrandId = brandId;
            CategoryId = categoryId;
            Price = price;
            ImageUri = imageUri;
            ProductBrand = brand;
            ProductCategory = category;
        }

        public string Name { get; private set; }

        public string? ImageUri { get; private set; }

        public string Description { get; private set; }

        public Brand? ProductBrand { get; private set; }

        public int BrandId { get; private set; }

        public int CategoryId { get; private set; }

        public Category? ProductCategory { get; private set; }

        public decimal Price { get; private set; }

        public void UpdatePrice (decimal newPrice) {

            //TODO: In uno scenario reale, normalmente questi valori (0 e 10_000) non sono cablati
            // direttamente nel codice ma gestiti (e centralizzati) in un altro punto.
            if( newPrice < 0 ) throw new ArgumentException("Il prezzo non può essere negativo");
            
            if( newPrice > 10_000 ) throw new ArgumentException("Il prezzo ha superato il limite");
            
            this.Price = newPrice;
        }

        public void UpdateDetails (string name,  string description, string imageUri)
        {
            if(string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException("Inserisci un nome per il prodotto");
            
            if (string.IsNullOrWhiteSpace(description)) throw new ArgumentNullException("Inserisci una descrizione per il prodotto");
            
            if (string.IsNullOrWhiteSpace(imageUri)) throw new ArgumentNullException("Inserisci url per l'immagine del prodotto");

            this.Name = name;
            this.Description = description;
            this.ImageUri = imageUri;
        }
    }
}
