using gms.data;
using gms.data.Models.Activity;
using gms.services.Base;

namespace gms.service.Activity.ActivityCategoryRepository;
public class ActivityCategoryService : BaseRepository<ActivityCategoryEntity>, IActivityCategoryService
{
    private readonly ApplicationDbContext _context;
    public ActivityCategoryService(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
