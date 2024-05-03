using Microsoft.EntityFrameworkCore;
using StudentPortalCrud.Models.Entities;

namespace StudentPortalCrud.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
