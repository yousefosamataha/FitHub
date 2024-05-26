using gms.data;
using gms.data.Models.Subscription;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace gms.service.Subscription.SubscriptionPaymentRepository;
public class SubscriptionPaymentService : BaseRepository<SubscriptionPaymentEntity>, ISubscriptionPaymentService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly ILogger<SubscriptionPaymentService> _logger;
	public SubscriptionPaymentService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor, ILogger<SubscriptionPaymentService> logger) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
		_logger = logger;
	}
}
