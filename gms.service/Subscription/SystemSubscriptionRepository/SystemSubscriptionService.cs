using gms.common.Models.SubscriptionCat.SystemSubscription;
using gms.data;
using gms.data.Mapper.Subscription;
using gms.data.Models.Subscription;
using gms.services.Base;

namespace gms.service.Subscription.SystemSubscriptionRepository;
public class SystemSubscriptionService : BaseRepository<SystemSubscriptionEntity>, ISystemSubscriptionService
{
    private readonly ApplicationDbContext _context;
    public SystemSubscriptionService(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<SystemSubscriptionDTO> CreateSystemSubscriptionAsync(CreateSystemSubscriptionDTO newSystemSubscription)
    {
        SystemSubscriptionEntity systemSubscriptionEntity = newSystemSubscription.ToEntity();
        await AddAsync(systemSubscriptionEntity);
        return systemSubscriptionEntity.ToDTO();
    }
}
