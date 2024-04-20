using gms.common.Constants;
using gms.data.Models.Gym;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;

internal class GymConfiguration : IEntityTypeConfiguration<GymEntity>
{
    public void Configure(EntityTypeBuilder<GymEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".Gym", gmsDbProperties.DbSchema);

        builder.HasKey(g => g.Id);

        builder.Property(g => g.Name).IsRequired().HasMaxLength(256);

        builder.HasOne(g => g.GeneralSetting)
               .WithOne(gg => gg.Gym)
               .HasForeignKey<GymEntity>(g => g.GeneralSettingId);

        builder.HasMany(g => g.SystemSubscriptions)
               .WithOne(ss => ss.Gym)
               .HasForeignKey(ss => ss.GymId);

        builder.HasMany(g => g.GymBranches)
               .WithOne(gb => gb.Gym)
               .HasForeignKey(gb => gb.GymId);

        builder.HasMany(g => g.GymGroups)
               .WithOne(ggr => ggr.Gym)
               .HasForeignKey(g => g.GymId);

        //builder.HasMany(g => g.GymMembershipPlans)
        //       .WithOne(gmp => gmp.Gym)
        //       .HasForeignKey(gmp => gmp.GymId);

        //builder.HasMany(g => g.GymMemberMemberships)
        //       .WithOne(gmm => gmm.Gym)
        //       .HasForeignKey(gmm => gmm.GymId);

        //builder.HasMany(g => g.MembershipPaymentHistories)
        //       .WithOne(gmph => gmph.Gym)
        //       .HasForeignKey(gmph => gmph.GymId);

        //builder.HasMany(g => g.GymUsers)
        //       .WithOne(gu => gu.Gym)
        //       .HasForeignKey(gu => gu.GymId);
    }
}
