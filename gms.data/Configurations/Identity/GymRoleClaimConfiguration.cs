using gms.common.Constants;
using gms.data.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;

internal class GymRoleClaimConfiguration : IEntityTypeConfiguration<GymRoleClaimEntity>
{
    public void Configure(EntityTypeBuilder<GymRoleClaimEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbIdentityTablePrefix + ".GymIdentityRoleClaim", gmsDbProperties.DbSchema);
    }
}
