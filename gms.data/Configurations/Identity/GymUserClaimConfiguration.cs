using gms.common.Constants;
using gms.data.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Identity;
internal class GymUserClaimConfiguration : IEntityTypeConfiguration<GymUserClaimEntity>
{
    public void Configure(EntityTypeBuilder<GymUserClaimEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbIdentityTablePrefix + ".GymUserClaim", gmsDbProperties.DbSchema);
    }
}
