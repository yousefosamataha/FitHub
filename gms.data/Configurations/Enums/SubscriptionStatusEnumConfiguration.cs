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

        builder.HasKey(ss => ss.Id);

        builder.Property(ss => ss.SubscriptionStatus).IsRequired(true);
        builder.Property(ss => ss.SubscriptionStatus).HasMaxLength(100);

        builder.HasData(GetSubscriptionStatuses());
    }

    public List<SubscriptionStatusEnumEntity> GetSubscriptionStatuses()
    {
        List<SubscriptionStatusEnumEntity> subscriptionStatuses = new();
        var bageColors = Enum.GetValues(typeof(BadgeColorEnum));
        foreach (var subscriptionStatus in Enum.GetValues(typeof(SubscriptionStatusEnum)))
        {
            SubscriptionStatusEnumEntity newSubscriptionStatus = new()
            {
                Id = (byte)subscriptionStatus,
                SubscriptionStatus = subscriptionStatus.ToString(),
                BadgeColorId = (byte)subscriptionStatus switch 
                {
                    1 => BadgeColorEnum.success,
                    2 => BadgeColorEnum.warning,
                    3 => BadgeColorEnum.secondary,
                    4 => BadgeColorEnum.danger
                },
                CreatedAt = DateTime.UtcNow
            };
            subscriptionStatuses.Add(newSubscriptionStatus);
        };
        return subscriptionStatuses;
    }
}
