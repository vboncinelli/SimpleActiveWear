using System.ComponentModel.DataAnnotations;

namespace ActiveWear.Web.Mvc.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? ImageUri { get; set; }

        public string? Description { get; set; }

        public BrandViewModel? ProductBrand { get; set; }

        public int? BrandId { get; set; }

        public int? CategoryId { get; set; }

        public CategoryViewModel? ProductCategory { get; set; }

        public decimal? Price { get; set; }
    }
}
