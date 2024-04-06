using gms.common.Constants;
using gms.common.Enums;
using gms.data.Models.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;

internal class StatusEnumConfiguration : IEntityTypeConfiguration<StatusEnumEntity>
{
    public void Configure(EntityTypeBuilder<StatusEnumEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".StatusEnum", gmsDbProperties.DbSchema);

        builder.HasKey(s => s.Id);

        builder.Property(s => s.Id).ValueGeneratedNever();

        builder.Property(s => s.SubscriptionStatus).IsRequired(true);

        builder.Property(s => s.SubscriptionStatus).HasMaxLength(100);

        builder.HasData(GetSubscriptionStatuses());
    }

    public List<StatusEnumEntity> GetSubscriptionStatuses()
    {
        List<StatusEnumEntity> statuses = new();

        foreach (var status in Enum.GetValues(typeof(StatusEnum)))
        {
            StatusEnumEntity newStatus = new()
            {
                Id = (byte)status,
                SubscriptionStatus = status.ToString(),
                BadgeColorId = (byte)status switch
                {
                    1 => BadgeColorEnum.success,
                    2 => BadgeColorEnum.danger,
                    3 => BadgeColorEnum.warning,
                    4 => BadgeColorEnum.secondary,
                    5 => BadgeColorEnum.danger,
                    6 => BadgeColorEnum.danger,
                    7 => BadgeColorEnum.warning,
                    8 => BadgeColorEnum.success
                },
                CreatedAt = DateTime.UtcNow
            };
            statuses.Add(newStatus);
        };
        return statuses;
    }
}
