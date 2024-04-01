using gms.common.Constants;
using gms.data.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Identity;
internal class GymUserTokenConfiguration : IEntityTypeConfiguration<GymUserTokenEntity>
{
    public void Configure(EntityTypeBuilder<GymUserTokenEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbIdentityTablePrefix + ".GymUserToken", gmsDbProperties.DbSchema);
    }
}
