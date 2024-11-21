using System.ComponentModel.DataAnnotations;

namespace CourseManagementApi.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; } = null!;
        public Guid CustomerInformationId { get; set; }
        public CustomerInformation CustomerInformation { get; set; } = null!;
        public DateTime EnrollmentDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}