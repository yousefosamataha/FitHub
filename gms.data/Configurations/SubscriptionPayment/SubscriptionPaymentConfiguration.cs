﻿using gms.common.Constants;
using gms.data.Models.Subscription;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.SubscriptionPayment;
internal class SubscriptionPaymentConfiguration : IEntityTypeConfiguration<SubscriptionPaymentEntity>
{
    public void Configure(EntityTypeBuilder<SubscriptionPaymentEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".SubscriptionPayment", gmsDbProperties.DbSchema);

        builder.HasKey(sp => sp.Id);

        builder.Property(sp => sp.PaidAmount).HasPrecision(18, 2);

        builder.HasOne(sp => sp.Subscription)
               .WithOne();
    }
}