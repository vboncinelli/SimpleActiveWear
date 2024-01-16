using System.ComponentModel.DataAnnotations.Schema;

namespace ActiveWear.Dal.Sql.Entities
{
    public class OrderItem: BaseDalEntity
    {
        public int OrderId { get; set; }

        public int ProductId { get; set; }
        
        public Product? Product { get; set; }
        
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18, 4)")]
        public decimal UnitPrice { get; set; }
    }
}
