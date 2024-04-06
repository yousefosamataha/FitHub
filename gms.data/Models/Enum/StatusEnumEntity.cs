using gms.common.Enums;
using gms.data.Models.Base.Entities;

namespace gms.data.Models.Enum;

public class StatusEnumEntity : BaseEntity
{
    public required string SubscriptionStatus { get; set; }
    public required BadgeColorEnum BadgeColorId { get; set; }
}
