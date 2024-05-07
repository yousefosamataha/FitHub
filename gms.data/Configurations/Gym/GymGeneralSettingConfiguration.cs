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

        builder.Property(gg => gg.Weight).HasDefaultValue("KG");
        builder.Property(gg => gg.Height).HasDefaultValue("Centimeter");
        builder.Property(gg => gg.Chest).HasDefaultValue("Inches");
        builder.Property(gg => gg.Waist).HasDefaultValue("Inches");
        builder.Property(gg => gg.Thing).HasDefaultValue("Inches");
        builder.Property(gg => gg.Arms).HasDefaultValue("Inches");
        builder.Property(gg => gg.Fat).HasDefaultValue("Percentage");
        builder.Property(gg => gg.ReminderDays).HasDefaultValue(5);
        builder.Property(gg => gg.ReminderMessage).HasDefaultValue("Hello {0},\r\n      Your Membership  {1}  started at {2} and it will expire on {3}.\r\nThank You.");

        builder.HasMany(gg => gg.GymBranches)
               .WithOne(gb => gb.GeneralSetting)
               .HasForeignKey(gb => gb.GeneralSettingId);

        builder.HasQueryFilter(gb => gb.IsDeleted == false);
    }
}
