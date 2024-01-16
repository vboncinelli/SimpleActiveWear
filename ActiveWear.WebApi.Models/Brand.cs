using System.ComponentModel.DataAnnotations;

namespace ActiveWear.WebApi.Models
{
    public class Brand: BaseApiEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
