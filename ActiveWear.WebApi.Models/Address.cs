using System.ComponentModel.DataAnnotations;

namespace ActiveWear.WebApi.Models
{
    public class Address
    {
        //TODO: attributi

        [Required]
        public string Street { get; set; } = null!;

        [Required]
        public string City { get; set; } = null!;

        [Required]
        public string StateOrProvince { get; set; } = null!;

        [Required]
        public string PostalCode { get; set; } = null!;

        [Required]
        public string Country { get; set; } = null!;
    }
}
