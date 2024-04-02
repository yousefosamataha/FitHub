using gms.data;
using gms.data.Models.Membership;
using gms.services.Base;

namespace gms.service.Membership.GymMembershipPaymentHistoryRepository;
public class GymMembershipPaymentHistoryService : BaseRepository<GymMembershipPaymentHistoryEntity>, IGymMembershipPaymentHistoryService
{
    private readonly ApplicationDbContext _context;
    public GymMembershipPaymentHistoryService(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
