namespace ActiveWear.Core.Entities
{
    public class CartItem : BaseEntity
    {
        public CartItem(
            int productId,
            int cartId,
            int quantity,
            decimal unitPrice,
            Product? product) 
        { 
            ProductId = productId;
            CartId = cartId;
            Quantity = quantity;
            UnitPrice = unitPrice;
            CartProduct = product;
        }
        public int ProductId { get; private set; }

        public int CartId { get; private set; }

        public Product? CartProduct { get; set; }

        public int Quantity { get; private set; }

        public decimal UnitPrice { get; private set; }

        public void UpdateQuantity(int quantity)
        {
            // TODO: In uno scenario reale, 0 e 999 sono definiti (e centralizzati) altrove (in genere come constanti) 
            // Non devono essere cablati direttamente nel codice (hard coded)
            if(quantity is < 0 || quantity is > 999) throw new ArgumentOutOfRangeException("La quantità deve essere compresa tra 0 e 999");
            
            this.Quantity = quantity;
        }

        public void UpdateUnitPrice(decimal unitPrice)
        {
            if (unitPrice is < 0 || unitPrice is > 10_000_000) throw new ArgumentOutOfRangeException();

            this.UnitPrice = unitPrice;
        }
    }
}
