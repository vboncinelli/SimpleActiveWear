using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActiveWear.Dal.Entities
{
    public class Brand: BaseDalEntity
    {
        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; } = null!;
    }
}
