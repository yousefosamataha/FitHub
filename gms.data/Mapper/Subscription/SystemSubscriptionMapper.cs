using gms.common.Models.SubscriptionCat.SystemSubscription;
using gms.data.Models.Subscription;

namespace gms.data.Mapper.Subscription;

public static class SystemSubscriptionMapper
{
    public static SystemSubscriptionEntity ToEntity(this CreateSystemSubscriptionDTO source)
    {
        return new SystemSubscriptionEntity()
        {
        };
    }

    public static SystemSubscriptionDTO ToDTO(this SystemSubscriptionEntity source)
    {
        return new SystemSubscriptionDTO()
        {
        };
    }
}
