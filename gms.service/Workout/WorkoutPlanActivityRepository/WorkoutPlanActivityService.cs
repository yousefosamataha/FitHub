using gms.common.Models.WorkoutCat.WorkoutPlanActivity;
using gms.data;
using gms.data.Mapper.Workout;
using gms.data.Models.Workout;
using gms.service.Activity.ActivityVideoRepository;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace gms.service.Workout.WorkoutPlanActivityRepository;
public class WorkoutPlanActivityService : BaseRepository<WorkoutPlanActivityEntity>, IWorkoutPlanActivityService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly ILogger<WorkoutPlanActivityService> _logger;
	public WorkoutPlanActivityService
	(
		ApplicationDbContext context,
		IHttpContextAccessor httpContextAccessor, 
		ILogger<WorkoutPlanActivityService> logger
	) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
		_logger = logger;
	}

	public async Task<bool> CreateNewWorkoutPlanActivitiesAsync(List<CreateWorkoutPlanActivityDTO> workoutPlanActivitiesList)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(ActivityVideoService), nameof(CreateNewWorkoutPlanActivitiesAsync), DateTime.Now.ToString() });

			List<WorkoutPlanActivityEntity> createWorkoutPlanActivitiesList = workoutPlanActivitiesList.Select(wpa => wpa.ToEntity()).ToList();
			await AddRangeAsync(createWorkoutPlanActivitiesList);
			return true;
		}
	}
}
