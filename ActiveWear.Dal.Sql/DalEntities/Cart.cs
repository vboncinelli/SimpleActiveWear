using System.ComponentModel.DataAnnotations;

namespace ActiveWear.Dal.Sql.Entities
{
    public class Cart: BaseDalEntity
    {
        [Required]
        public int CustomerId { get; set; }

        public List<CartItem> Items { get; set;} = new List<CartItem> ();
    }
}
