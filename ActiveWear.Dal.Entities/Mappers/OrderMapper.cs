using Domain = ActiveWear.Core.Entities;
using EF = ActiveWear.Dal.Entities;

namespace ActiveWear.Dal.Mappers
{
    public static class OrderMapper
    {
        public static Domain.OrderItem ToDomain(this EF.OrderItem orderItem)
        {
            var itemOrdered = new Domain.ProductOrdered(orderItem.ProductId, orderItem.Product!.Name, orderItem.Product.ImageUri);

            var dalItem = new Domain.OrderItem(itemOrdered, orderItem.UnitPrice, orderItem.Quantity);

            return dalItem;
        }

        public static Domain.Order ToDomain(this EF.Order dalEntity)
        {
            var items = new List<Domain.OrderItem>();
            foreach (var item in dalEntity.Items)
                items.Add(item.ToDomain());

            var address = new Domain.Address(
                street: dalEntity.Street,
                city: dalEntity.City,
                stateOrProvince: dalEntity.StateOrProvince,
                country: dalEntity.Country,
                postalCode: dalEntity.ZipCode);

            var order = new Domain.Order(dalEntity.CustomerId, address, items);

            return order;
        }

        public static EF.Order ToDal(this Domain.Order order)
        {
            var items = new List<EF.OrderItem>();
            foreach (var item in order.Items)
                items.Add(item.ToDal());

            var dalOrder = new EF.Order()
            {
                Id = order.Id,
                CustomerId = order.CustomerId,
                OrderDate = order.OrderDate,
                Street = order.ShipToAddress.Street,
                City = order.ShipToAddress.City,
                StateOrProvince = order.ShipToAddress.StateOrProvince,
                Country = order.ShipToAddress.Country,
                ZipCode = order.ShipToAddress.PostalCode,
                Items = items
            };

            return dalOrder;
        }

        public static EF.OrderItem ToDal(this Domain.OrderItem orderItem)
        {
            var dalItem = new EF.OrderItem()
            {
                Id = orderItem.Id,
                ProductId = orderItem.ItemOrdered.ProductId,
                UnitPrice = orderItem.UnitPrice,
                Quantity = orderItem.Quantity
            };

            return dalItem;
        }
    }
}
