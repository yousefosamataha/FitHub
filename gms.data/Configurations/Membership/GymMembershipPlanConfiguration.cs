﻿using gms.common.Constants;
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

        builder.HasOne(gmp => gmp.GymBranch)
               .WithMany(gb => gb.GymMembershipPlans)
               .HasForeignKey(gmp => gmp.BranchId);

        builder.HasMany(gmp => gmp.GymMemberMemberships)
               .WithOne(gmm => gmm.GymMembershipPlan)
               .HasForeignKey(gmm => gmm.GymMembershipPlanId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(gmp => gmp.MembershipPlanClasses)
               .WithOne(gmpc => gmpc.MembershipPlan)
               .HasForeignKey(gmpc => gmpc.MembershipPlanId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(gmp => gmp.MembershipActivities)
               .WithOne(ma => ma.MembershipPlan)
               .HasForeignKey(ma => ma.MembershipPlanId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasQueryFilter(gmp => gmp.IsDeleted == false);
    }
}