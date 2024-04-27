using gms.data;
using gms.data.Models.Membership;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Membership.GymMembershipPlanRepository;
public class GymMembershipPlanService : BaseRepository<GymMembershipPlanEntity>, IGymMembershipPlanService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public GymMembershipPlanService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }

}
