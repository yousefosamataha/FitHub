using gms.common.Constants;
using gms.data.Models.Gym;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;

internal class GymBranchConfiguration : IEntityTypeConfiguration<GymBranchEntity>
{
    public void Configure(EntityTypeBuilder<GymBranchEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".GymBranch", gmsDbProperties.DbSchema);

        builder.HasKey(gb => gb.Id);

        builder.Property(gb => gb.BranchName).IsRequired().HasMaxLength(256);

        builder.Property(gb => gb.StartYear).IsRequired();

        builder.Property(gb => gb.Address).IsRequired();

        builder.Property(gb => gb.ContactNumber).IsRequired();

        builder.Property(gb => gb.Email).IsRequired();

        builder.HasOne(gb => gb.Gym)
               .WithMany(g => g.GymBranches)
               .HasForeignKey(gb => gb.GymId);

        builder.HasOne(gb => gb.Country)
               .WithMany()
               .HasForeignKey(gb => gb.CountryId);

        builder.HasOne(gb => gb.GeneralSetting)
               .WithOne(gg => gg.GymBranch)
               .HasForeignKey<GymBranchEntity>(gb => gb.GeneralSettingId);

        builder.HasMany(gb => gb.GymBranchUsers)
               .WithOne(gbu => gbu.GymBranch)
               .HasForeignKey(gb => gb.GymBranchId);

        builder.HasMany(gb => gb.GymMembershipPlans)
               .WithOne(gmp => gmp.GymBranch)
               .HasForeignKey(gmp => gmp.BranchId);

        builder.HasMany(gb => gb.GymMemberMemberships)
               .WithOne(gmm => gmm.GymBranch)
               .HasForeignKey(gmm => gmm.GymId);

        builder.HasMany(gb => gb.MembershipPaymentHistories)
               .WithOne(gmph => gmph.GymBranch)
               .HasForeignKey(gmph => gmph.GymId);
    }
}
