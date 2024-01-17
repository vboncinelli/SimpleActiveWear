using System.ComponentModel.DataAnnotations;

namespace ActiveWear.WebApi.Models
{
    public class Product: BaseApiEntity
    {
        public string Name { get; set; }

        public string? ImageUri { get; set; }

        public string Description { get; set; }

        public Brand? ProductBrand { get; set; }

        public int BrandId { get; set; }

        public int CategoryId { get; set; }

        public Category? ProductCategory { get; set; }

        [Range(0, int.MaxValue)]
        public decimal Price { get; set; }
    }
}
