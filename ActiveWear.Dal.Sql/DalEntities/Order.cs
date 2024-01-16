namespace ActiveWear.Dal.Sql.Entities
{
    public class Order: BaseDalEntity
    {
        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }

        public required string Street { get; set; }

        public required string City { get; set; }

        public required string StateOrProvince { get; set; }

        public required string Country { get; set; }

        public required string ZipCode { get; set; }

        public List<OrderItem> Items { get; set;} = new List<OrderItem>();
    }
}
