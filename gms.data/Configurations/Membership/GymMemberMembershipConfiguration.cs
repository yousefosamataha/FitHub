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

        builder.HasOne(gmm => gmm.GymMembershipPlan)
               .WithMany(gmp => gmp.GymMemberMemberships)
               .HasForeignKey(gmm => gmm.GymMembershipPlanId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(gmp => gmp.GymMemberUser)
               .WithMany(gu => gu.GymMemberMemberships)
               .HasForeignKey(gmp => gmp.MemberId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(gmm => gmm.MembershipPaymentHistories)
               .WithOne(gmph => gmph.GymMemberMembership)
               .HasForeignKey(gmph => gmph.GymMemberMembershipId);
    }
}
