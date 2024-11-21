using CourseManagementApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseManagementApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Account> Accounts { get; set; } = null!;
        public DbSet<Course> Courses { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<CustomerInformation> CustomerInformations { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public DbSet<Discount> Discounts { get; set; } = null!;
        public DbSet<CourseInformation> CourseInformations { get; set; } = null!;
        public DbSet<CourseContent> CourseContents { get; set; } = null!;
        public DbSet<Class> Classes { get; set; } = null!;
        public DbSet<Enrollment> Enrollments { get; set; } = null!;
        public DbSet<Question> Questions { get; set; } = null!;
        public DbSet<Instructor> Instructors { get; set; } = null!;
    }   
}
