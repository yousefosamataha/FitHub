﻿using gms.common.Constants;
using gms.data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Subscription;

internal class SystemSubscriptionConfiguration : IEntityTypeConfiguration<SystemSubscriptionEntity>
{
    public void Configure(EntityTypeBuilder<SystemSubscriptionEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".SystemSubscription", gmsDbProperties.DbSchema);
        
        builder.HasKey(ss => ss.Id);
        
        builder.Property(ss => ss.SubscriptionAmount).HasPrecision(18, 2);

        builder.HasOne(ss => ss.Plan)
               .WithOne()
               .HasForeignKey<PlanEntity>(sp => sp.Id);

        builder.HasOne(ss => ss.SubscriptionStatus)
               .WithOne()
               .HasForeignKey<SubscriptionStatusEnumEntity>(sp => sp.Id);

        builder.HasOne(ss => ss.SubscriptionType)
               .WithOne()
               .HasForeignKey<SubscriptionTypeEnumEntity>(sp => sp.Id);

    }
}