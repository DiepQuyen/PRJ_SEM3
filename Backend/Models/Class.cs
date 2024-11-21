using System.ComponentModel.DataAnnotations;

namespace CourseManagementApi.Models
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}