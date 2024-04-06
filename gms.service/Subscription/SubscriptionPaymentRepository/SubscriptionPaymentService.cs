using gms.data;
using gms.data.Models.Subscription;
using gms.services.Base;

namespace gms.service.Subscription.SubscriptionPaymentRepository;
public class SubscriptionPaymentService : BaseRepository<SubscriptionPaymentEntity>, ISubscriptionPaymentService
{
    private readonly ApplicationDbContext _context;
    public SubscriptionPaymentService(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
