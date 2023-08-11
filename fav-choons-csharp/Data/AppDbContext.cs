
using Microsoft.EntityFrameworkCore;

namespace fav_choons_csharp.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
    }
}

namespace PostgreSQL.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
    }
}



namespace PostgreSQL.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Artist> Artists { get; set; }
    }
}