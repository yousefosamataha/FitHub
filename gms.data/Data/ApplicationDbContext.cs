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
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
