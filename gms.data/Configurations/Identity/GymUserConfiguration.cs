using gms.common.Constants;
using gms.data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Identity;
internal class GymUserConfiguration : IEntityTypeConfiguration<GymUserEntity>
{
    public void Configure(EntityTypeBuilder<GymUserEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbIdentityTablePrefix + ".GymUser", gmsDbProperties.DbSchema);
        builder.Property(gu => gu.Address).IsRequired(false);
        builder.Property(gu => gu.City).IsRequired(false);
        builder.Property(gu => gu.State).IsRequired(false);
    }
}
