using gms.common.Constants;
using gms.data.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Identity;
internal class GymUserLoginConfiguration : IEntityTypeConfiguration<GymUserLoginEntity>
{
    public void Configure(EntityTypeBuilder<GymUserLoginEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbIdentityTablePrefix + ".GymUserLogin", gmsDbProperties.DbSchema);
    }
}
