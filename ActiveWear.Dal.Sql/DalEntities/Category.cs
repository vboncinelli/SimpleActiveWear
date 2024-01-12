namespace ActiveWear.Dal.Sql.Entities
{
    public class Category: BaseDalEntity
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

    }
}
