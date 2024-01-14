using System.ComponentModel.DataAnnotations;

namespace ActiveWear.Dal.Sql.Entities
{
    // TODO: controllare tutte le entità e utilizzare gli attributi 
    // per decorare le proprietà, qualora sia necessario. Vedi "Product" per un esempio.
    public abstract class BaseDalEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
