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

        public virtual DbSet<Category> Categories { get; set; }

        public ActiveWearContext(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public ActiveWearContext()
        {
            this._connectionString = "Data Source=localhost;Initial Catalog=ActiveWearShop;Integrated Security=true;TrustServerCertificate=true;";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this._connectionString);

            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            
            optionsBuilder.EnableDetailedErrors();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
