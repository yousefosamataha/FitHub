using gms.common.Models.SubscriptionCat.SystemSubscription;
using gms.data.Models.Subscription;

namespace gms.data.Mapper.Subscription;

public static class SystemSubscriptionMapper
{
    public static SystemSubscriptionEntity ToEntity(this CreateSystemSubscriptionDTO source)
    {
        return new SystemSubscriptionEntity()
        {
            PlanId = source.PlanId,
            GymId = source.GymId,
        };
    }

    public static SystemSubscriptionDTO ToDTO(this SystemSubscriptionEntity source)
    {
        return new SystemSubscriptionDTO()
        {
            PlanId = source.PlanId,
            GymId = source.GymId,
            SubscriptionTypeId = source.SubscriptionTypeId,
            SubscriptionAmount = source.SubscriptionAmount,
            SubscriptionStartTime = source.SubscriptionStartTime,
            SubscriptionEndTime = source.SubscriptionEndTime,
            SubscriptionStatusId = source.SubscriptionStatusId,
        };
    }
}
