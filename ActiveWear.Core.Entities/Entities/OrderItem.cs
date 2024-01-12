namespace ActiveWear.Core.Entities
{
    public class OrderItem: BaseEntity
    {
        public ProductOrdered ItemOrdered { get; private set; } = null!;

        public decimal UnitPrice { get; private set; }

        public int Quantity { get; private set; }

        public OrderItem(ProductOrdered itemOrdered, decimal unitPrice, int quantity)
        {
            this.ItemOrdered = itemOrdered;
            this.UnitPrice = unitPrice;
            this.Quantity = quantity;
        }

        public void UpdateUnits(int delta)
        {
            if (this.Quantity + delta < 1)
                throw new InvalidOperationException("The number of remaining units cannot be negative");

            this.Quantity += delta;
        }
    }
}
