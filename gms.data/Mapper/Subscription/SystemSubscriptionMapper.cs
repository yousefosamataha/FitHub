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
            SubscriptionTypeId = source.SubscriptionTypeId,
            CreatedById = source.CreatedById
		};
    }

    public static SystemSubscriptionDTO ToDTO(this SystemSubscriptionEntity source)
    {
        return new SystemSubscriptionDTO()
        {
            Id = source.Id,
            PlanId = source.PlanId,
            GymId = source.GymId,
            SubscriptionTypeId = source.SubscriptionTypeId,
            SubscriptionAmount = source.SubscriptionAmount,
            SubscriptionStartTime = source.SubscriptionStartTime,
            SubscriptionEndTime = source.SubscriptionEndTime,
            SubscriptionStatusId = source.SubscriptionStatusId,
            CreatedById = (int)source.CreatedById            
        };
    }

	public static SystemSubscriptionEntity ToUpdatedEntity(this SystemSubscriptionDTO source, SystemSubscriptionEntity entity)
	{
		entity.PlanId = source.PlanId;
		entity.GymId = source.GymId > default(int) && source.GymId != entity.GymId ? source.GymId : entity.GymId;
		entity.SubscriptionTypeId = source.SubscriptionTypeId;
		entity.SubscriptionAmount = source.SubscriptionAmount;
		entity.SubscriptionStartTime = source.SubscriptionStartTime;
		entity.SubscriptionEndTime = source.SubscriptionEndTime;
		entity.SubscriptionStatusId = source.SubscriptionStatusId;
		entity.CreatedById = source.CreatedById > default(int) && source.CreatedById != entity.CreatedById ? source.CreatedById : entity.CreatedById;

		return entity;
	}
}
