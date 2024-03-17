using gms.common.Constants;
using gms.data.Models.Gym;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Gym;
internal class GymGeneralSettingConfiguration : IEntityTypeConfiguration<GymGeneralSettingEntity>
{
    public void Configure(EntityTypeBuilder<GymGeneralSettingEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".GymGeneralSetting", gmsDbProperties.DbSchema);

        builder.HasKey(gg => gg.Id);

        builder.Property(gg => gg.Weight).IsRequired(false);

        builder.Property(gg => gg.Height).IsRequired(false);

        builder.Property(gg => gg.Chest).IsRequired(false);

        builder.Property(gg => gg.Waist).IsRequired(false);

        builder.Property(gg => gg.Thing).IsRequired(false);

        builder.Property(gg => gg.Arms).IsRequired(false);

        builder.Property(gg => gg.Fat).IsRequired(false);

    }
}
