using gms.common.Constants;
using gms.data.Models.Subscription;
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

    }
}
