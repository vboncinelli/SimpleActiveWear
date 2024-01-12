namespace ActiveWear.Web.Api.Models
{
    /// <summary>
    /// Represents a snapshot of the item that was ordered. If catalog item details change, details of
    /// the item that was part of a completed order should not change.
    /// </summary>
    public class ProductOrdered
    {
        //TODO: Da decorare. Tutti gli elementi sono obbligatori

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string PictureUri { get; set; }
    }
}
