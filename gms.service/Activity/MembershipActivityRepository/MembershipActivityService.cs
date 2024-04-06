using gms.data;
using gms.data.Models.Activity;
using gms.services.Base;

namespace gms.service.Activity.MembershipActivityRepository;
public class MembershipActivityService : BaseRepository<MembershipActivityEntity> , IMembershipActivityService
{
    private readonly ApplicationDbContext _context;
    public MembershipActivityService(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
