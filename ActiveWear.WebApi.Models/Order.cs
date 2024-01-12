namespace ActiveWear.WebApi.Models
{
    public class Order: BaseEntity
    {
        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }

        public List<OrderItem> Items { get; set;} = new List<OrderItem>();
    }
}
