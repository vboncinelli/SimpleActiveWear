namespace ActiveWear.Dal.Sql.Entities
{
    public class OrderItem: BaseDalEntity
    {
        public int OrderId { get; private set; }

        public int ProductId { get; private set; }
        
        public Product? Product { get; private set; }
        
        public int Quantity { get; private set; }
        
        public decimal UnitPrice { get; private set; }
    }
}
