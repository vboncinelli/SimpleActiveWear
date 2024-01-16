using System.ComponentModel.DataAnnotations;

namespace ActiveWear.WebApi.Models
{
    /// <summary>
    /// Represents a snapshot of the item that was ordered. If catalog item details change, details of
    /// the item that was part of a completed order should not change.
    /// </summary>
    public class ProductOrdered
    {
        [Required]
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; } = null!;

        public string? PictureUri { get; set; }
    }
}
