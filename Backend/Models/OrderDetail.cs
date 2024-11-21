using System.ComponentModel.DataAnnotations;

namespace CourseManagementApi.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
        public decimal Price { get; set; }
        public int? DiscountId { get; set; }
        public Discount? Discount { get; set; }
        public string Status { get; set; } = "pending";
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}