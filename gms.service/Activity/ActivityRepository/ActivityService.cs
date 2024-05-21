using FluentResults;
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

	public async Task<Result<ActivityDTO>> CreateNewActivityAsync(CreateActivityDTO createActivityDto)
	{
		ActivityEntity createActivity = createActivityDto.ToEntity();
		createActivity.BranchId = GetBranchId();
		await AddAsync(createActivity);
		return Result.Ok(createActivity.ToDTO());
	}

	public async Task<Result<List<ActivityDTO>>> GetActivitiesListAsync()
	{
		List<ActivityEntity> listOfActivities = await FindAllAsync(a => a.BranchId == GetBranchId(), ["ActivityCategory"]);
		if (listOfActivities is null || !listOfActivities.Any())
		{
			return Result.Fail(new Error(""));
		}
		return Result.Ok(listOfActivities.Select(a => a.ToDTO()).ToList());
	}

	public async Task<Result<ActivityDTO>> GetActivityAsync(int id)
	{
		ActivityEntity activityEntity = await FindAsync(a => a.Id == id && a.BranchId == GetBranchId());

		if (activityEntity is null)
		{
			return Result.Fail(new Error(""));
		}

		return Result.Ok(activityEntity.ToDTO());
	}

	public async Task<Result<ActivityDTO>> UpdateActivityAsync(UpdateActivityDTO updateActivityDto)
	{
		ActivityEntity curentActivityEntity = await FindAsync(a => a.Id == updateActivityDto.Id);
		ActivityEntity updatedActivityEntity = updateActivityDto.ToUpdatedEntity(curentActivityEntity);
		await UpdateAsync(updatedActivityEntity);
		return Result.Ok(updatedActivityEntity.ToDTO());
	}

	public async Task<Result> DeleteActivityAsync(int activityId)
	{
		ActivityEntity activityEntity = await FindAsync(a => a.Id == activityId && a.BranchId == GetBranchId());
		await DeleteAsync(activityEntity);
		return Result.Ok();
	}
}
