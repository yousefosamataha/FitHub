using gms.common.Constants;
using gms.data.Models.Membership;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;

internal class GymMembershipPlanConfiguration : IEntityTypeConfiguration<GymMembershipPlanEntity>
{
    public void Configure(EntityTypeBuilder<GymMembershipPlanEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".GymMembershipPlan", gmsDbProperties.DbSchema);

        builder.HasKey(gmp => gmp.Id);

        builder.Property(gmp => gmp.MembershipName).IsRequired().HasMaxLength(256);

        builder.Property(gmp => gmp.MembershipAmount).HasPrecision(18, 2);

        builder.Property(gmp => gmp.SignupFee).HasPrecision(18, 2);

        //builder.HasOne(gmp => gmp.Gym)
        //       .WithMany(g => g.GymMembershipPlans)
        //       .HasForeignKey(gmp => gmp.GymId);

        //builder.HasOne(gmp => gmp.GymBranch)
        //       .WithMany(gb => gb.GymMembershipPlans)
        //       .HasForeignKey(gmp => gmp.BranchId);

        //builder.HasOne(gmp => gmp.GymStaffUser)
        //       .WithOne()
        //       .HasForeignKey<GymMembershipPlanEntity>(gmp => gmp.CreatedById);

        builder.HasMany(gmp => gmp.GymMemberMemberships)
               .WithOne(gmm => gmm.GymMembershipPlan)
               .HasForeignKey(gmm => gmm.GymMembershipPlanId);

        builder.HasMany(gmp => gmp.MembershipPlanClasses)
               .WithOne(mpc => mpc.MembershipPlan)
               .HasForeignKey(mpc => mpc.MembershipPlanId);
    }
}