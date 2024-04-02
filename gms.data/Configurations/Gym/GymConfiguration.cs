using gms.common.Constants;
using gms.data.Models.Gym;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Gym;

internal class GymConfiguration : IEntityTypeConfiguration<GymEntity>
{
    public void Configure(EntityTypeBuilder<GymEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".Gym", gmsDbProperties.DbSchema);

        builder.HasKey(g => g.Id);

        builder.Property(g => g.Name).IsRequired().HasMaxLength(256);

        builder.HasMany(g => g.GymBranches)
               .WithOne(gb => gb.Gym)
               .HasForeignKey(gb => gb.GymId);

        builder.HasOne(g => g.GeneralSetting)
               .WithOne(gg => gg.Gym)
               .HasForeignKey<GymGeneralSettingEntity>(gg => gg.GymId);

        builder.HasMany(g => g.GymUsers)
               .WithOne(gu => gu.Gym)
               .HasForeignKey(gu => gu.GymId);
    }
}
