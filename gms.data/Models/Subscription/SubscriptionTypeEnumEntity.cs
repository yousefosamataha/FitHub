using gms.data.Models.Base;

namespace gms.data.Models.Subscription;

public class SubscriptionTypeEnumEntity : BaseEntity
{
    public required string SubscriptionType { get; set; }
}