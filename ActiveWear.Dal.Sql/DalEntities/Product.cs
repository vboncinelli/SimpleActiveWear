using System.ComponentModel.DataAnnotations.Schema;

namespace ActiveWear.Dal.Sql.Entities
{
    public class Product: BaseDalEntity
    {
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; } = null!;

        [Column(TypeName = "nvarchar(max)")]
        public string? ImageUri { get; set; }

        [Column(TypeName = "nvarchar(2000)")]
        public string Description { get; set; } = null!;

        public Brand? ProductBrand { get; set; }

        public int BrandId { get; set; }

        public int CategoryId { get; set; }

        public Category? ProductCategory { get; set; }

        [Column(TypeName = "decimal(18, 4)")]
        public decimal Price { get; set; }
    }
}
