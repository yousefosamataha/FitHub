using gms.common.Models.ActivityCat.ActivityVideo;
using gms.data;
using gms.data.Mapper.Activity;
using gms.data.Models.Activity;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace gms.service.Activity.ActivityVideoRepository;
public class ActivityVideoService : BaseRepository<ActivityVideoEntity>, IActivityVideoService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly ILogger<ActivityVideoService> _logger;
	public ActivityVideoService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor, ILogger<ActivityVideoService> logger) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
		_logger = logger;
	}

	public async Task<bool> CreateNewActivityVideosAsync(List<CreateActivityVideoDTO> activityVideoListDto)
	{
		List<ActivityVideoEntity> createActivityVideoList = activityVideoListDto.Select(av => av.ToEntity()).ToList();
		await AddRangeAsync(createActivityVideoList);
		return true;
	}

	public async Task<List<ActivityVideoDTO>> GetActivityVideosListAsync(int activityId)
	{
		List<ActivityVideoEntity> listOfActivityVideos = await FindAllAsync(av => av.ActivityId == activityId);
		return listOfActivityVideos.Select(av => av.ToDTO()).ToList();
	}

	public async Task<bool> UpdateActivityVideosAsync(List<CreateActivityVideoDTO> updateActivityVideosListDto, int activityId)
	{
		List<ActivityVideoEntity> currentActivityVideosList = await FindAllAsync(av => av.ActivityId == activityId);
		await DeleteRangeAsync(currentActivityVideosList);
		List<ActivityVideoEntity> newActivityVideosList = updateActivityVideosListDto.Select(av => av.ToEntity()).ToList();
		await AddRangeAsync(newActivityVideosList);
		return true;
	}
}
