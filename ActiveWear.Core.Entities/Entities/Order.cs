using ActiveWear.Core.Exceptions;

namespace ActiveWear.Core.Entities
{
    public class Order: BaseEntity
    {
        public DateTime OrderDate { get; private set; }

        public int CustomerId { get; private set; }

        public Address ShipToAddress { get; private set; } = null!;


        public List<OrderItem> Items { get; private set;} = new List<OrderItem>();

        public Order(int customerId, Address shipToAddress, List<OrderItem> orderItems)
        {
            this.CustomerId = customerId;
            this.ShipToAddress = shipToAddress;
            this.Items = orderItems;
        }

        public decimal GetTotal()
        {
            var total = 0m;

            foreach (var item in this.Items)
            {
                total += item.UnitPrice * item.Quantity;
            }

            return total;
        }

        public void AddOrderItems(List<OrderItem> items)
        {
            if (items.Count > 0)
            {
                foreach (var item in items)
                {
                    var existingItemIndex = this.Items.FindIndex(e => e.ItemOrdered.ProductId == item.ItemOrdered.ProductId);

                    if (existingItemIndex < 0)
                        this.Items.Add(item);
                    else
                        // in a real app this logic would be more complex and fine-grained
                        this.Items[existingItemIndex].UpdateUnits(1);
                }
            }
        }

        public void RemoveOrderItem(int orderItemId)
        {
            var existingItemIndex = this.Items.FindIndex(e => e.Id == orderItemId);

            if (existingItemIndex < 0)
                throw new EntityNotFoundException($"Order item with id {orderItemId} not found");

            this.Items.RemoveAt(existingItemIndex);
        }
    }
}
