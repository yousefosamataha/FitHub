using gms.common.Constants;
using gms.common.Enums;
using gms.data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Enums;

internal class SubscriptionTypeEnumConfiguration : IEntityTypeConfiguration<SubscriptionTypeEnumEntity>
{
    public void Configure(EntityTypeBuilder<SubscriptionTypeEnumEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".SubscriptionTypeEnum", gmsDbProperties.DbSchema);
        builder.Property(st => st.SubscriptionType).IsRequired(true);
        builder.Property(st => st.SubscriptionType).HasMaxLength(100);
        builder.HasData(GetSubscriptionTypes());
    }

    public List<SubscriptionTypeEnumEntity> GetSubscriptionTypes()
    {
        List<SubscriptionTypeEnumEntity> subscriptionTypes = new();
        foreach (var subscriptionType in Enum.GetValues(typeof(SubscriptionTypeEnum)))
        {
            SubscriptionTypeEnumEntity newSubscriptiontType = new()
            {
                Id = (byte)subscriptionType,
                SubscriptionType = subscriptionType.ToString(),
                CreatedAt = DateTime.UtcNow
            };
            subscriptionTypes.Add(newSubscriptiontType);
        };
        return subscriptionTypes;
    }
}
