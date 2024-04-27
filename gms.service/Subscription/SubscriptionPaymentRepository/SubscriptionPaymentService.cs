using gms.data;
using gms.data.Models.Subscription;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Subscription.SubscriptionPaymentRepository;
public class SubscriptionPaymentService : BaseRepository<SubscriptionPaymentEntity>, ISubscriptionPaymentService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public SubscriptionPaymentService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }
}
