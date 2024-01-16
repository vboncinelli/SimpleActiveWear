using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActiveWear.Dal.Sql.Entities
{
    public class Address : BaseDalEntity
    {
        [Required]
        public string Street { get; set; } = null!;

        public string City { get; set; } = null!;

        public string StateOrProvince { get; set; } = null!;

        public string PostalCode { get; set; } = null!;

        public string Country { get; set; } = null!;
    }
}
