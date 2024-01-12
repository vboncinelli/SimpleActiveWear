using ActiveWear.Dal.Sql.Entities;
using Microsoft.EntityFrameworkCore;

namespace ActiveWear.Dal.Sql.Context
{
    public class ActiveWearContext : DbContext
    {
        private readonly string _connectionString;

        public virtual DbSet<Address> Addresses { get; set; }

        public virtual DbSet<Cart> Baskets { get; set; }

        public virtual DbSet<CartItem> BasketItems { get; set; }

        public virtual DbSet<Brand> Brands { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<OrderItem> OrderItems { get; set; }

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<Category> ProductCategory { get; set; }

        public ActiveWearContext(string connectionString)
        {
            this._connectionString = connectionString;
        }
    }
}
