using gms.common.Models.ActivityCat.Activity;
using gms.data;
using gms.data.Mapper.Activity;
using gms.data.Models.Activity;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using System.Linq.Dynamic.Core;

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

	public async Task<ActivityDTO> CreateNewActivityAsync(CreateActivityDTO createActivityDto)
	{
        ActivityEntity createActivity = createActivityDto.ToEntity();
		createActivity.BranchId = GetBranchId();
		await AddAsync(createActivity);
		return createActivity.ToDTO();
	}

	public async Task<List<ActivityDTO>> GetActivitiesListAsync()
    {
        List<ActivityEntity> listOfActivities = await FindAllAsync(a => a.BranchId == GetBranchId(), ["ActivityCategory"]);
        return listOfActivities.Select(a => a.ToDTO()).ToList();
    }
}
