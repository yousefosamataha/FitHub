using gms.common.Models.ActivityCat.ActivityVideo;
using gms.data.Models.Activity;
using gms.services.Base;

namespace gms.service.Activity.ActivityVideoRepository;
public interface IActivityVideoService : IBaseRepository<ActivityVideoEntity>
{
	Task<bool> CreateNewActivityVideosAsync(List<CreateActivityVideoDTO> activityVideoListDto);
	Task<List<ActivityVideoDTO>> GetActivityVideosListAsync(int activityId);
	Task<bool> UpdateActivityVideosAsync(List<CreateActivityVideoDTO> updateActivityVideosListDto, int activityId);
}
