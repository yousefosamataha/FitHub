using gms.common.Constants;
using gms.data.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;

internal class GymUserClaimConfiguration : IEntityTypeConfiguration<GymUserClaimEntity>
{
    public void Configure(EntityTypeBuilder<GymUserClaimEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbIdentityTablePrefix + ".GymIdentityUserClaim", gmsDbProperties.DbSchema);
    }
}
