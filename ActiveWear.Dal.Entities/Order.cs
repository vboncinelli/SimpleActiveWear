using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActiveWear.Dal.Entities
{
    public class Order: BaseDalEntity
    {
        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string Street { get; set; } = null!;

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string City { get; set; } = null!;

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string StateOrProvince { get; set; } = null!;

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string Country { get; set; } = null!;

        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string ZipCode { get; set; } = null!;

        public List<OrderItem> Items { get; set;} = new List<OrderItem>();
    }
}
