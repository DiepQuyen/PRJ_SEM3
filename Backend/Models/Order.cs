using System.ComponentModel.DataAnnotations;

namespace CourseManagementApi.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public Guid CustomerInformationId { get; set; }
        public CustomerInformation CustomerInformation { get; set; } = null!;
        public decimal TotalPrice { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}