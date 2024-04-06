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

        builder.HasMany(gmm => gmm.MembershipPaymentHistories)
               .WithOne(gmph => gmph.GymMemberMembership)
               .HasForeignKey(gmph => gmph.GymMemberMembershipId);

        builder.HasOne(gmm => gmm.GymMembershipPlan)
               .WithMany(gmp => gmp.GymMemberMemberships)
               .HasForeignKey(gmp => gmp.GymMembershipPlanId);
    }
}
