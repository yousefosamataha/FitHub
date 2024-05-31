using gms.common.Models.SubscriptionCat.SystemSubscription;
using gms.data.Models.Subscription;
using gms.services.Base;

namespace gms.service.Subscription.SystemSubscriptionRepository;
public interface ISystemSubscriptionService : IBaseRepository<SystemSubscriptionEntity>
{
	Task<SystemSubscriptionDTO> CreateSystemSubscriptionAsync(CreateSystemSubscriptionDTO newSystemSubscription);

	Task<SystemSubscriptionDTO> UpdateSystemSubscriptionAsync(SystemSubscriptionDTO updateSystemSubscriptionDTO);
}
