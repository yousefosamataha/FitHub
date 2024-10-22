﻿using gms.common.Constants;
using gms.data.Models.Activity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;

internal class MembershipActivityConfiguration : IEntityTypeConfiguration<MembershipActivityEntity>
{
    public void Configure(EntityTypeBuilder<MembershipActivityEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".MembershipActivity", gmsDbProperties.DbSchema);

        builder.HasKey(ma => ma.Id);

        builder.HasOne(ma => ma.Activity)
               .WithMany(a => a.MembershipActivities)
               .HasForeignKey(ma => ma.ActivityId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(ma => ma.MembershipPlan)
               .WithMany(gmp => gmp.MembershipActivities)
               .HasForeignKey(ma => ma.MembershipPlanId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
