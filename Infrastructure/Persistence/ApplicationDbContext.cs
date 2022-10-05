using Domain.Entities.SystemEntities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        public DbSet<DriverSystemEntity> Drivers { get; set; }
        public DbSet<RiderSystemEntity> Riders { get; set; }
        public DbSet<DriverDropedRiderSystemEntity> Droped { get; set; }
    }
}
