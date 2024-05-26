using gms.common.Models.ActivityCat.Activity;
using gms.data;
using gms.data.Mapper.Activity;
using gms.data.Models.Activity;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Linq.Dynamic.Core;

namespace gms.service.Activity.ActivityRepository;
public class ActivityService : BaseRepository<ActivityEntity>, IActivityService
{
	private readonly ApplicationDbContext _context;
	private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly ILogger<ActivityService> _logger;
	public ActivityService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor, ILogger<ActivityService> logger) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
		_logger = logger;
	}

	public async Task<ActivityDTO> CreateNewActivityAsync(CreateActivityDTO createActivityDto)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Controller}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(ActivityService), nameof(CreateNewActivityAsync), DateTime.Now.ToString() });

			ActivityEntity createActivity = createActivityDto.ToEntity();
			createActivity.BranchId = GetBranchId();
			await AddAsync(createActivity);
			return createActivity.ToDTO();
		}
		
	}

	public async Task<List<ActivityDTO>> GetActivitiesListAsync()
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(ActivityService), nameof(GetActivitiesListAsync), DateTime.Now.ToString() });

			List<ActivityEntity> listOfActivities = await FindAllAsync(a => a.BranchId == GetBranchId(), ["ActivityCategory"]);
			return listOfActivities.Select(a => a.ToDTO()).ToList();
		}
		
	}

	public async Task<ActivityDTO> GetActivityAsync(int id)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(ActivityService), nameof(GetActivityAsync), DateTime.Now.ToString() });

			ActivityEntity activityEntity = await FindAsync(a => a.Id == id && a.BranchId == GetBranchId());
			return activityEntity.ToDTO();
		}
		
    }

	public async Task<ActivityDTO> UpdateActivityAsync(UpdateActivityDTO updateActivityDto)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(ActivityService), nameof(UpdateActivityAsync), DateTime.Now.ToString() });

			ActivityEntity curentActivityEntity = await FindAsync(a => a.Id == updateActivityDto.Id);
			ActivityEntity updatedActivityEntity = updateActivityDto.ToUpdatedEntity(curentActivityEntity);
			await UpdateAsync(updatedActivityEntity);
			return updatedActivityEntity.ToDTO();
		}
		
    }

	public async Task<bool> DeleteActivityAsync(int activityId)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(ActivityService), nameof(DeleteActivityAsync), DateTime.Now.ToString() });

			ActivityEntity activityEntity = await FindAsync(a => a.Id == activityId && a.BranchId == GetBranchId());
			await DeleteAsync(activityEntity);
			return true;
		}
		
	}
}
