using System.ComponentModel.DataAnnotations.Schema;

namespace ActiveWear.Dal.Sql.Entities
{
    public class OrderItem: BaseDalEntity
    {
        public int OrderId { get; private set; }

        public int ProductId { get; private set; }
        
        public Product? Product { get; private set; }
        
        public int Quantity { get; private set; }

        [Column(TypeName = "decimal(18, 4)")]
        public decimal UnitPrice { get; private set; }
    }
}
