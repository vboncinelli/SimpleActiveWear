namespace ActiveWear.WebApi.Models
{
    public class Product: BaseEntity
    {
        public string Name { get; set; }
        public Season Season { get; set; }
        public string ImageUri { get; set; }
        public string Description { get; set; }
        public Brand? ProductBrand { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public Category? ProductCategory { get; set; }
        public decimal Price { get; set; }
    }
}
