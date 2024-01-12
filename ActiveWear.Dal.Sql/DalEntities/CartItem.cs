namespace ActiveWear.Dal.Sql.Entities
{
    public class CartItem
    {
        public int ProductId { get; set; }

        public int CartId { get; set; }

        public Product? CartProduct { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
