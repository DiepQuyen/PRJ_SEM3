using System.ComponentModel.DataAnnotations;

namespace CourseManagementApi.Models
{
    public class CourseInformation
    {
        [Key]
        public int CourseInformationId { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public string Duration { get; set; } = null!;
        public string StudyLevel { get; set; } = null!;
        public string TopicsIncluded { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}