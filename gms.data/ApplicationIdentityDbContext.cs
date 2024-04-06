using gms.data.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace gms.data;
public class ApplicationIdentityDbContext : IdentityDbContext<GymUserEntity, GymIdentityRoleEntity, int, GymUserClaimEntity, GymUserRoleEntity, GymUserLoginEntity, GymRoleClaimEntity, GymUserTokenEntity>
{

    public ApplicationIdentityDbContext(DbContextOptions<ApplicationIdentityDbContext> options) : base(options)
    {
    }

    #region Identity
    public DbSet<GymRoleClaimEntity> RoleClaims { get; set; }

    public DbSet<GymIdentityRoleEntity> Roles { get; set; }

    public DbSet<GymUserClaimEntity> UserClaims { get; set; }

    public DbSet<GymUserEntity> Users { get; set; }

    public DbSet<GymUserLoginEntity> UserLogins { get; set; }

    public DbSet<GymUserRoleEntity> UserRoles { get; set; }

    public DbSet<GymUserTokenEntity> UserTokens { get; set; }

    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(assembly: Assembly.GetExecutingAssembly(),
        predicate: t => t.Namespace != null && t.Namespace.Equals("gms.data.IdentityConfiguration"));
    }
}
