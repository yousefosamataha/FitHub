using gms.common.Models.ActivityCat.Activity;
using gms.data.Models.Activity;
using gms.services.Base;

namespace gms.service.Activity.ActivityRepository;
public interface IActivityService : IBaseRepository<ActivityEntity>
{
	Task<ActivityDTO> CreateNewActivityAsync(CreateActivityDTO createActivityDto);
	Task<List<ActivityDTO>> GetActivitiesListAsync();
	Task<ActivityDTO> GetActivityAsync(int id);
	Task<ActivityDTO> UpdateActivityAsync(UpdateActivityDTO updateActivityDto);

    Task<bool> DeleteActivityAsync(int activityId);
}
