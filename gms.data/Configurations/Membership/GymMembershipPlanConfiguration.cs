using gms.common.Constants;
using gms.data.Models.Membership;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Membership;
internal class GymMembershipPlanConfiguration : IEntityTypeConfiguration<GymMembershipPlanEntity>
{
    public void Configure(EntityTypeBuilder<GymMembershipPlanEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".GymMembershipPlan", gmsDbProperties.DbSchema);

        builder.HasKey(gmp => gmp.Id);

        builder.Property(gmp => gmp.MembershipAmount).HasPrecision(18, 2);
        builder.Property(gmp => gmp.SignupFee).HasPrecision(18, 2);
        builder.Property(gmp => gmp.InstallmentAmount).HasPrecision(18, 2);

        builder.HasMany(gmp => gmp.GymMemberMemberships)
               .WithOne(gmm => gmm.GymMembershipPlan)
               .HasForeignKey(gmm => gmm.GymMembershipPlanId);
    }
}