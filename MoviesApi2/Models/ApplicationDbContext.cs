using Microsoft.EntityFrameworkCore;

namespace MoviesApi2.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
            
        }
        public DbSet<Genre> Genres { get; set; }
    }
}
