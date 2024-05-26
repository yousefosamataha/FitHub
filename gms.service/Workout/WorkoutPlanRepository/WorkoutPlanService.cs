using gms.data;
using gms.data.Models.Workout;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace gms.service.Workout.WorkoutPlanRepository;
public class WorkoutPlanService : BaseRepository<WorkoutPlanEntity>, IWorkoutPlanService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly ILogger<WorkoutPlanService> _logger;
	public WorkoutPlanService
	(
		ApplicationDbContext context, 
		IHttpContextAccessor httpContextAccessor, 
		ILogger<WorkoutPlanService> logger
	) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
		_logger = logger;
	}
}
