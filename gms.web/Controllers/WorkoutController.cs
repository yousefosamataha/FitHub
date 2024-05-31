using gms.common.Models.WorkoutCat.WorkoutPlan;
using gms.service.Workout.WorkoutPlanRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

[Authorize]
public class WorkoutController : BaseController<WorkoutController>
{
    private readonly IWorkoutPlanService _workoutPlanService;
    public WorkoutController(IWorkoutPlanService workoutPlanService)
    {
        _workoutPlanService = workoutPlanService;
    }
    public async Task<IActionResult> Index()
    {
        List<WorkoutPlanDTO> workoutPlans = await _workoutPlanService.GetWorkoutPlanListForBranchAsync();
        return View(workoutPlans);
    }
}
