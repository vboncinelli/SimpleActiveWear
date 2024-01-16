using ApiModels = ActiveWear.WebApi.Models;
using Domain = ActiveWear.Core.Entities;

namespace ActiveWear.WebApi.Mappers
{
    internal static class CartMapping
    {
        public static ApiModels.Cart ToApi(this Domain.Cart basket)
        { 
            return new ApiModels.Cart()
            {
                Id = basket.Id,
                CustomerId = basket.CustomerId,
                Items = basket.Items.ToApi()
            };
        }

        internal static ApiModels.CartItem ToApi(this Domain.CartItem cartItem)
        {
            return new ApiModels.CartItem()
            {
                Id = cartItem.Id,
                CartId = cartItem.CartId,
                CartProduct = cartItem.CartProduct.ToApi(),
                Quantity = cartItem.Quantity,
                UnitPrice = cartItem.UnitPrice
            };
        }

        internal static List<ApiModels.CartItem> ToApi(this IEnumerable<Domain.CartItem> collection)
        {
            var items = new List<ApiModels.CartItem>();
            foreach (var item in collection)
                items.Add(item.ToApi()!);

            return items;
        }
    }
}
