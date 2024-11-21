using System.ComponentModel.DataAnnotations;

namespace CourseManagementApi.Models
{
    public class Instructor
    {
        [Key]
        public int InstructorId { get; set; }
        public string Name { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public string? Bio { get; set; }
        public string? ImageLink { get; set; }
        public string? PhoneNumber { get; set; }
        public string Email { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}