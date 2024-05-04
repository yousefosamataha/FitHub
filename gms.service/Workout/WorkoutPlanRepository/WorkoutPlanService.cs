using gms.data;
using gms.data.Models.Workout;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Workout.WorkoutPlanRepository;
public class WorkoutPlanService : BaseRepository<WorkoutPlanEntity>, IWorkoutPlanService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public WorkoutPlanService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }
}
