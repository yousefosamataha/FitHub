using gms.data;
using gms.data.Models.Membership;
using gms.services.Base;

namespace gms.service.Membership.GymMemberMembershipRepository;
public class GymMemberMembershipService : BaseRepository<GymMemberMembershipEntity>, IGymMemberMembershipService
{
    private readonly ApplicationDbContext _context;
    public GymMemberMembershipService(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
