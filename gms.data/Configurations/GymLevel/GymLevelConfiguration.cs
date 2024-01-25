using gms.common.Constants;
using gms.data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.GymLevel;
internal class GymLevelConfiguration : IEntityTypeConfiguration<GymLevelEntity>
{
    public void Configure(EntityTypeBuilder<GymLevelEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".gym_levels", gmsDbProperties.DbSchema);

        builder.Property(g => g.Level).HasMaxLength(100);
    }
}
