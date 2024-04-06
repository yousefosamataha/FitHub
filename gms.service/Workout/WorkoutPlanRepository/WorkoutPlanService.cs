using gms.data;
using gms.data.Models.Workout;
using gms.services.Base;

namespace gms.service.Workout.WorkoutPlanRepository;
public class WorkoutPlanService : BaseRepository<WorkoutPlanEntity>, IWorkoutPlanService
{
    private readonly ApplicationDbContext _context;
    public WorkoutPlanService(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
