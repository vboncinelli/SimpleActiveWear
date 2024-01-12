namespace ActiveWear.WebApi.Models
{
    public class Cart: BaseEntity
    {
        public int CustomerId { get; set; }

        public List<CartItem> Items { get; set;} = new List<CartItem> ();
    }
}
