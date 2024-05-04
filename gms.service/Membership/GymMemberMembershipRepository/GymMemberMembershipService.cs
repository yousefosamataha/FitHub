using gms.data;
using gms.data.Models.Membership;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Membership.GymMemberMembershipRepository;
public class GymMemberMembershipService : BaseRepository<GymMemberMembershipEntity>, IGymMemberMembershipService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public GymMemberMembershipService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }

}
