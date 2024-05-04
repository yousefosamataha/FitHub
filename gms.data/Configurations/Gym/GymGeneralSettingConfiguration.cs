using gms.common.Constants;
using gms.data.Models.Gym;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;
internal class GymGeneralSettingConfiguration : IEntityTypeConfiguration<GymGeneralSettingEntity>
{
    public void Configure(EntityTypeBuilder<GymGeneralSettingEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".GymGeneralSetting", gmsDbProperties.DbSchema);

        builder.HasKey(gg => gg.Id);

        builder.HasMany(gg => gg.GymBranches)
               .WithOne(gb => gb.GeneralSetting)
               .HasForeignKey(gb => gb.GeneralSettingId);

        builder.HasQueryFilter(gb => gb.IsDeleted == false);
    }
}
