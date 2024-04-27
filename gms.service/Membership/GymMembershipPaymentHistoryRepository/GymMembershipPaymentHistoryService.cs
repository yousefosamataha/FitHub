using gms.data;
using gms.data.Models.Membership;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Membership.GymMembershipPaymentHistoryRepository;
public class GymMembershipPaymentHistoryService : BaseRepository<GymMembershipPaymentHistoryEntity>, IGymMembershipPaymentHistoryService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public GymMembershipPaymentHistoryService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }

}
