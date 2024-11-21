using System.ComponentModel.DataAnnotations;

namespace CourseManagementApi.Models
{
    public class CustomerInformation
    {
        [Key]
        public Guid CustomerInformationId { get; set; } // UUID
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public decimal? Mark { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}