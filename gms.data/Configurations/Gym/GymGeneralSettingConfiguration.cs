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

        //builder.HasOne(gg => gg.Gym)
        //       .WithOne(g => g.GeneralSetting)
        //       .HasForeignKey<GymGeneralSettingEntity>(gg => gg.GymId);

        //builder.HasOne(gg => gg.GymBranch)
        //       .WithOne(gb => gb.GeneralSetting)
        //       .HasForeignKey<GymGeneralSettingEntity>(gg => gg.BranchId);
    }
}
