using gms.common.Constants;
using gms.data.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;

internal class GymUserRoleConfiguration : IEntityTypeConfiguration<GymUserRoleEntity>
{
    public void Configure(EntityTypeBuilder<GymUserRoleEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbIdentityTablePrefix + ".GymIdentityUserRole", gmsDbProperties.DbSchema);
    }
}
