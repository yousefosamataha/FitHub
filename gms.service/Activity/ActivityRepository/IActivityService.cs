using FluentResults;
using gms.common.Models.ActivityCat.Activity;
using gms.data.Models.Activity;
using gms.services.Base;

namespace gms.service.Activity.ActivityRepository;
public interface IActivityService : IBaseRepository<ActivityEntity>
{
	Task<Result<ActivityDTO>> CreateNewActivityAsync(CreateActivityDTO createActivityDto);
	Task<Result<List<ActivityDTO>>> GetActivitiesListAsync();
	Task<Result<ActivityDTO>> GetActivityAsync(int id);
	Task<Result<ActivityDTO>> UpdateActivityAsync(UpdateActivityDTO updateActivityDto);
	Task<Result> DeleteActivityAsync(int activityId);
}
