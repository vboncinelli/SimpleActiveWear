using ApiModels = ActiveWear.WebApi.Models;
using Domain = ActiveWear.Core.Entities;

namespace ActiveWear.WebApi.Mappers
{
    internal static class OrderMapping
    {
        internal static ApiModels.Order ToApi(this Domain.Order order)
        {
            return new ApiModels.Order()
            {
                Id = order.Id,
                CustomerId = order.CustomerId,
                OrderDate = order.OrderDate,
                ShipToAddress = order.ShipToAddress.ToApi(),
                Items = order.Items.ToApi(),
            };
        }

        internal static IEnumerable<ApiModels.Order> ToApi(this IEnumerable<Domain.Order> orders)
        {
            var list = new List<ApiModels.Order>();

            foreach(var order in orders)
                list.Add(order.ToApi());

            return list;
        }

        internal static ApiModels.OrderItem? ToApi(this Domain.OrderItem item)
        {
            if (item is null) return null;

            return new ApiModels.OrderItem()
            {
                Id = item.Id,
                UnitPrice = item.UnitPrice,
                Quantity = item.Quantity,
                ItemOrdered = item.ItemOrdered.ToApi(),
            };
        }

        internal static List<ApiModels.OrderItem> ToApi(this IEnumerable<Domain.OrderItem> items)
        {
            var list = new List<ApiModels.OrderItem>();

            foreach (var item in items)
                if (item != null) 
                    list.Add(item.ToApi()!);

            return list;
        }

        internal static ApiModels.ProductOrdered ToApi(this Domain.ProductOrdered productOrdered)
        {
            return new ApiModels.ProductOrdered()
            {
                ProductId = productOrdered.ProductId,
                PictureUri = productOrdered.PictureUri,
                ProductName = productOrdered.ProductName
            };
        }

        internal static ApiModels.Address ToApi(this Domain.Address address)
        {
            return new ApiModels.Address()
            {
                City = address.City,
                Country = address.Country,
                StateOrProvince = address.StateOrProvince,
                Street = address.Street,
                PostalCode = address.PostalCode,
            };
        }
    }
}
