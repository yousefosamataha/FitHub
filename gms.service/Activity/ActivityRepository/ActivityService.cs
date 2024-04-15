using gms.data;
using gms.data.Models.Activity;
using gms.services.Base;

namespace gms.service.Activity.ActivityRepository;
public class ActivityService : BaseRepository<ActivityEntity>, IActivityService
{
    private readonly ApplicationDbContext _context;
    public ActivityService(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
