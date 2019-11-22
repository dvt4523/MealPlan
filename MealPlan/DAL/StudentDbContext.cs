using Microsoft.EntityFrameworkCore;
using MealPlan.DAL.Entities;
namespace MealPlan.DAL
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Student> Students { get; set; }
    }
}
