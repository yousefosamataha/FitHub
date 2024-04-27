using gms.data;
using gms.data.Models.Activity;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Activity.ActivityVideoRepository;
public class ActivityVideoService : BaseRepository<ActivityVideoEntity>, IActivityVideoService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public ActivityVideoService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }

}
