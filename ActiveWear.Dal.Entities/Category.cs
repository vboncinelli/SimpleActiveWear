using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActiveWear.Dal.Entities
{
    public class Category: BaseDalEntity
    {
        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; } = null!;

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string Description { get; set; } = null!;

    }
}
