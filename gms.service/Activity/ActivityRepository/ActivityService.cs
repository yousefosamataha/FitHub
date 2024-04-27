using gms.data;
using gms.data.Models.Activity;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Activity.ActivityRepository;
public class ActivityService : BaseRepository<ActivityEntity>, IActivityService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public ActivityService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }

}
