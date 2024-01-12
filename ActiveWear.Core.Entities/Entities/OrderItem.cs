using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveWear.Core.Entities
{
    public class OrderItem: BaseEntity
    {
        public OrderItem(int orderId, int productId, int quantity, decimal unitPrice)
        {
            OrderId = orderId;
            ProductId = productId;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
        public int OrderId { get; private set; }
        public int ProductId { get; private set; }
        public Product? Product { get; private set; }
        public int Quantity { get; private set; }
        public decimal UnitPrice { get; private set; }

    }
}
