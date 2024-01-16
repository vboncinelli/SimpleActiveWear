namespace ActiveWear.WebApi.Models
{
    public class Order: BaseApiEntity
    {
        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }

        public Address? ShipToAddress { get; set; }

        public List<OrderItem> Items { get; set;} = new List<OrderItem>();
    }
}
