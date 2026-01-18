using Microsoft.EntityFrameworkCore;
using MyStoryTeamAPI.Models.Db;

namespace MyStoryTeamAPI.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<DbUser> Users { get; set; }
        public DbSet<DbTest> Tests { get; set; }
    }
}
