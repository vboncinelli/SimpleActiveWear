using ActiveWear.Core.Interfaces;
using ActiveWear.Dal.Sql.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ActiveWear.Dal.Sql
{
    public class ShopRepository : IShopRepository
    {
        private readonly string _connectionString;

        public ShopRepository(IConfiguration configuration)
        {
            this._connectionString = configuration.GetConnectionString("ActiveWearShop") ?? throw new ArgumentNullException(nameof(_connectionString));
        }

        protected virtual DbContext GetContext()
        {
            return new ActiveWearContext(this._connectionString);
        }
    }
}
