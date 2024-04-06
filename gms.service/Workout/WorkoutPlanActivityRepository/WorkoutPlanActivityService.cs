using gms.data;
using gms.data.Models.Workout;
using gms.services.Base;

namespace gms.service.Workout.WorkoutPlanActivityRepository;
public class WorkoutPlanActivityService : BaseRepository<WorkoutPlanActivityEntity>
{
    private readonly ApplicationDbContext _context;
    public WorkoutPlanActivityService(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
