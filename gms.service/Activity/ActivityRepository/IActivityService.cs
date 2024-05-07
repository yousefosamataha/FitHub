using gms.common.Models.ActivityCat.Activity;
using gms.data.Models.Activity;
using gms.services.Base;

namespace gms.service.Activity.ActivityRepository;
public interface IActivityService : IBaseRepository<ActivityEntity>
{
	Task<ActivityDTO> CreateNewActivityAsync(CreateActivityDTO createActivityDto);
	Task<List<ActivityDTO>> GetActivitiesListAsync();
}
