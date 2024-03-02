using gms.common.Constants;
using gms.common.Enums;
using gms.data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Enums;

internal class SubscriptionStatusEnumConfiguration : IEntityTypeConfiguration<SubscriptionStatusEnumEntity>
{
    public void Configure(EntityTypeBuilder<SubscriptionStatusEnumEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".SubscriptionStatusEnum", gmsDbProperties.DbSchema);
        builder.Property(st => st.SubscriptionStatus).IsRequired(true);
        builder.Property(st => st.SubscriptionStatus).HasMaxLength(100);
        builder.HasData(GetSubscriptionStatuses());
    }

    public List<SubscriptionStatusEnumEntity> GetSubscriptionStatuses()
    {
        List<SubscriptionStatusEnumEntity> subscriptionStatuses = new();
        foreach (var subscriptionStatus in Enum.GetValues(typeof(SubscriptionStatusEnum)))
        {
            SubscriptionStatusEnumEntity newSubscriptiontStatus = new()
            {
                 Id = (byte)subscriptionStatus,
                 SubscriptionStatus = subscriptionStatus.ToString(),
                 CreatedAt = DateTime.UtcNow
            };
            subscriptionStatuses.Add(newSubscriptiontStatus);
        };
        return subscriptionStatuses;
    }
}
