namespace ActiveWear.Dal.Sql.Entities
{
    public class Order: BaseDalEntity
    {
        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }

        public List<OrderItem> Items { get; set;} = new List<OrderItem>();
    }
}
