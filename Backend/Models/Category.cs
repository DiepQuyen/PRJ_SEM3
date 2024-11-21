using System.ComponentModel.DataAnnotations;

namespace CourseManagementApi.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}