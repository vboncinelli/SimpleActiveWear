namespace ActiveWear.WebApi.Models
{
    public class OrderItem: BaseApiEntity
    {
        // TODO: Decorare con attributi
        public int OrderId { get; set; }

        public required ProductOrdered ItemOrdered { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
