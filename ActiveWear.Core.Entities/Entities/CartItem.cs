using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveWear.Core.Entities
{
    public class CartItem
    {
        public CartItem(
            int productId,
            int cartId,
            int quantity,
            decimal unitPrice) 
        { 
            ProductId = productId;
            CartId = cartId;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
        public int ProductId { get; set; }

        public int CartId { get; set; }

        public Product? CartProduct { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public void UpdateQuantity(int quantity)
        {
            if(quantity < 0 || quantity > 999) {
                throw new ArgumentOutOfRangeException("La quantità inserita è minore o maggiore al range prestabilito");
            }

            Quantity = quantity;
        }
    }
}
