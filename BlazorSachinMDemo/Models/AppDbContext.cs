using Microsoft.EntityFrameworkCore;

namespace BlazorSachinMDemo.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Club> Clubs { get; set; }
    }
}
