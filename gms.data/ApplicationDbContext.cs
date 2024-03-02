using gms.data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace gms.data;
public class ApplicationDbContext : IdentityDbContext<GymUserEntity>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<IdentityRoleClaim<string>> RoleClaims { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityUserClaim<string>> UserClaims { get; set; }
    public DbSet<GymUserEntity> Users { get; set; }
    public DbSet<IdentityUserLogin<string>> UserLogins { get; set; }
    public DbSet<IdentityUserRole<string>> UserRoles { get; set; }
    public DbSet<IdentityUserToken<string>> UserTokens { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
