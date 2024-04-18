using gms.common.Constants;
using gms.data.Models.Membership;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;

internal class GymMembershipPaymentHistoryConfiguration : IEntityTypeConfiguration<GymMembershipPaymentHistoryEntity>
{
    public void Configure(EntityTypeBuilder<GymMembershipPaymentHistoryEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".GymMembershipPaymentHistory", gmsDbProperties.DbSchema);

        builder.HasKey(gmph => gmph.Id);

        builder.Property(gmph => gmph.PaidAmount).HasPrecision(18, 2);

        builder.HasOne(gmph => gmph.Gym)
               .WithMany(g => g.MembershipPaymentHistories)
               .HasForeignKey(gmph => gmph.GymId);

        builder.HasOne(gmph => gmph.GymBranch)
               .WithMany(gb => gb.MembershipPaymentHistories)
               .HasForeignKey(gmph => gmph.BranchId);

        builder.HasOne(gmph => gmph.GymMemberMembership)
               .WithMany(gmm => gmm.MembershipPaymentHistories)
               .HasForeignKey(gmph => gmph.GymMemberMembershipId);

        builder.HasOne(gmph => gmph.GymStaffUser)
               .WithOne()
               .HasForeignKey<GymMembershipPaymentHistoryEntity>(gmph => gmph.CreatedById);
    }
}
