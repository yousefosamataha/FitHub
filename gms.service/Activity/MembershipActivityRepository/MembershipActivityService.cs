using gms.data;
using gms.data.Models.Activity;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Activity.MembershipActivityRepository;
public class MembershipActivityService : BaseRepository<MembershipActivityEntity>, IMembershipActivityService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public MembershipActivityService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }


}
