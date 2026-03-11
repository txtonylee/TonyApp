using System.ComponentModel.DataAnnotations;
namespace TonyApp.Models

{
    /// <summary>
    /// Product model representing a product in the inventory system.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Unique identifier for the product.
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the product.
        /// </summary>
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name is too long")]
        public string? Name { get; set; }
        /// <summary>
        /// Detailed description of the product.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Category classification for the product.
        /// </summary>
        public string Category { get; set; } = string.Empty;
        /// <summary>
        /// Price of the product.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Quantity available in stock.
        /// </summary>
        public int Qty { get; set; }
        /// <summary>
        /// Date and time when the product was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// Date and time when the product was last modified.
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }
        /// <summary>
        /// Indicates whether the product is currently active.
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// Supplier information for the product.
        /// </summary>
        public string? Supplier { get; set; }
        /// <summary>
        /// URL to an image representing the product.
        /// </summary>
        public string? ImageUrl { get; set; }
    }
}