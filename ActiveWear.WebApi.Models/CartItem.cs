using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveWear.WebApi.Models
{
    public class CartItem
    {
        public int ProductId { get; set; }

        public int CartId { get; set; }

        public Product? CartProduct { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
