namespace ActiveWear.Dal.Sql.Entities
{
    public class Cart: BaseDalEntity
    {
        public int CustomerId { get; set; }

        public List<CartItem> Items { get; set;} = new List<CartItem> ();
    }
}
