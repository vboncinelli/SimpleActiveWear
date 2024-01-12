namespace ActiveWear.Core.Entities
{
    public class Cart: BaseEntity
    {
        public int CustomerId { get; set; }

        public List<CartItem> Items { get; set;} = new List<CartItem> ();

        // TODO: costruttore che accetta un customer Id

        // TODO: metodo per aggiungere items al carrello
    }
}
