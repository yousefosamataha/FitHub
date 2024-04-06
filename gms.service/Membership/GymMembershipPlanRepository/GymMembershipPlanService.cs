using gms.data;
using gms.data.Models.Membership;
using gms.services.Base;

namespace gms.service.Membership.GymMembershipPlanRepository;
public class GymMembershipPlanService : BaseRepository<GymMembershipPlanEntity>, IGymMembershipPlanService
{
    private readonly ApplicationDbContext _context;
    public GymMembershipPlanService(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
