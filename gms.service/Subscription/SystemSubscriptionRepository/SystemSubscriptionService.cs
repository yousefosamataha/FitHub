using gms.common.Models.SubscriptionCat.SystemSubscription;
using gms.data;
using gms.data.Mapper.Subscription;
using gms.data.Models.Subscription;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Subscription.SystemSubscriptionRepository;
public class SystemSubscriptionService : BaseRepository<SystemSubscriptionEntity>, ISystemSubscriptionService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public SystemSubscriptionService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<SystemSubscriptionDTO> CreateSystemSubscriptionAsync(CreateSystemSubscriptionDTO newSystemSubscription)
    {
        SystemSubscriptionEntity systemSubscriptionEntity = newSystemSubscription.ToEntity();
        await AddAsync(systemSubscriptionEntity);
        return systemSubscriptionEntity.ToDTO();
    }
}
