using gms.data;
using gms.data.Models.Workout;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Workout.WorkoutPlanActivityRepository;
public class WorkoutPlanActivityService : BaseRepository<WorkoutPlanActivityEntity>
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public WorkoutPlanActivityService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }
}
