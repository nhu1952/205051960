using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [System.ComponentModel.DisplayName("Tên sản phẩm")]
        public string? Name { get; set; }
        [System.ComponentModel.DisplayName("Mô tả sản phẩm ")]
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public virtual Category? category { get; set; }
    }
}
