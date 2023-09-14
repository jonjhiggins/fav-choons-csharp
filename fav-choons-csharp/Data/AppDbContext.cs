
using Microsoft.EntityFrameworkCore;
using fav_choons_csharp.Data.Models;

namespace fav_choons_csharp.Data
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