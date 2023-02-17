using Microsoft.EntityFrameworkCore;

namespace XML_Dependency.Models.DataContexts
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options) { }
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Food> Foods { get; set; } = null!;

    }
}
