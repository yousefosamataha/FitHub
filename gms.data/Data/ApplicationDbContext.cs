using gms.data.Models;
using Microsoft.EntityFrameworkCore;

namespace gms.entityframeworkcore.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<CategoryEntity> Categories { get; set; }
    public DbSet<GymEventPlaceEntity> GymEventPlaces { get; set; }
    public DbSet<GymGroupEntity> GymGroups { get; set; }
    public DbSet<GymInterestAreaEntity> GymInterestAreas { get; set; }
    public DbSet<GymLevelEntity> GymLevels { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
