using gms.common.Constants;
using gms.data.Models.Membership;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;

internal class GymMemberMembershipConfiguration : IEntityTypeConfiguration<GymMemberMembershipEntity>
{
    public void Configure(EntityTypeBuilder<GymMemberMembershipEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".GymMemberMembership", gmsDbProperties.DbSchema);

        builder.HasKey(gmm => gmm.Id);

        builder.HasOne(gmm => gmm.Gym)
               .WithMany(g => g.GymMemberMemberships)
               .HasForeignKey(gmm => gmm.GymId);

        builder.HasOne(gmm => gmm.GymBranch)
               .WithMany(gb => gb.GymMemberMemberships)
               .HasForeignKey(gmm => gmm.BranchId);

        builder.HasOne(gmm => gmm.GymMembershipPlan)
               .WithMany(gmp => gmp.GymMemberMemberships)
               .HasForeignKey(gmm => gmm.GymMembershipPlanId);

        builder.HasOne(gmp => gmp.GymMemberUser)
               .WithOne()
               .HasForeignKey<GymMemberMembershipEntity>(gmp => gmp.MemberId);

        //builder.HasOne(gmp => gmp.GymStaffUser)
        //       .WithOne()
        //       .HasForeignKey<GymMemberMembershipEntity>(gmp => gmp.CreatedById);

        builder.HasMany(gmm => gmm.MembershipPaymentHistories)
               .WithOne(gmph => gmph.GymMemberMembership)
               .HasForeignKey(gmph => gmph.GymMemberMembershipId);
    }
}
