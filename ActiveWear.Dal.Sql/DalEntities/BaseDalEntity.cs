using System.ComponentModel.DataAnnotations;

namespace ActiveWear.Dal.Sql.Entities
{
    public abstract class BaseDalEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
