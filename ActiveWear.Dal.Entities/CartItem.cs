using System.ComponentModel.DataAnnotations.Schema;

namespace ActiveWear.Dal.Entities
{
    public class CartItem : BaseDalEntity
    {
        public int ProductId { get; set; }

        public int CartId { get; set; }

        public Product? CartProduct { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18, 4)")]
        public decimal UnitPrice { get; set; }
    }
}
