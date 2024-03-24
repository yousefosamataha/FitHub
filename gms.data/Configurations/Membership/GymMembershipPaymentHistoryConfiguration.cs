using gms.common.Constants;
using gms.data.Models.Membership;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Membership;
internal class GymMembershipPaymentHistoryConfiguration : IEntityTypeConfiguration<GymMembershipPaymentHistoryEntity>
{
    public void Configure(EntityTypeBuilder<GymMembershipPaymentHistoryEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".GymMembershipPaymentHistory", gmsDbProperties.DbSchema);

        builder.HasKey(gmph => gmph.Id);

        builder.Property(gmph => gmph.PaidAmount).HasPrecision(18, 2);

        builder.HasOne(gmph => gmph.GymMemberMembership)
               .WithMany(gmm => gmm.MembershipPaymentHistories)
               .HasForeignKey(gmm => gmm.GymMemberMembershipId);
    }
}
