using gms.data;
using gms.data.Models.Workout;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace gms.service.Workout.WorkoutPlanActivityRepository;
public class WorkoutPlanActivityService : BaseRepository<WorkoutPlanActivityEntity>
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
}
