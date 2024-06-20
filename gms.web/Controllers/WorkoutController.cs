using gms.common.Models.WorkoutCat.WorkoutPlan;
using gms.common.ViewModels.Workout;
using gms.service.Activity.ActivityRepository;
using gms.service.Identity.GymUserRepository;
using gms.service.Workout.WorkoutPlanActivityRepository;
using gms.service.Workout.WorkoutPlanRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

[Authorize]
public class WorkoutController : BaseController<WorkoutController>
{
    private readonly IWorkoutPlanService _workoutPlanService;
    private readonly IGymUserService _gymUserService;
    private readonly IActivityService _activityService;
	private readonly IWorkoutPlanActivityService _workoutPlanActivityService;
	public WorkoutController(IWorkoutPlanService workoutPlanService, IGymUserService gymUserService, IActivityService activityService, IWorkoutPlanActivityService workoutPlanActivityService)
	{
		_workoutPlanService = workoutPlanService;
		_gymUserService = gymUserService;
		_activityService = activityService;
		_workoutPlanActivityService = workoutPlanActivityService;
	}
	public async Task<IActionResult> Index()
    {
        List<WorkoutPlanDTO> workoutPlans = await _workoutPlanService.GetWorkoutPlanListAsync();
        return View(workoutPlans);
    }

    public async Task<IActionResult> AddNewWorkoutPlan()
    {
		AddNewWorkoutPlanVM model = new ();
		model.GymMembersList = await _gymUserService.GetGymMemberUsersListAsync();
		model.ActivitiesList = await _activityService.GetActivitiesListAsync();

		return View(model);
    }

	[HttpPost]
	public async Task<JsonResult> AddNewWorkoutPlan(AddNewWorkoutPlanVM model)
	{
		WorkoutPlanDTO createdWorkoutPlan = await _workoutPlanService.CreateWorkoutPlanAsync(model.CreateWorkoutPlan);
        foreach (var wpa in model.CreateWorkoutPlanActivities)
        {
			wpa.WorkoutPlanId = createdWorkoutPlan.Id;
		}
		await _workoutPlanActivityService.CreateNewWorkoutPlanActivitiesAsync(model.CreateWorkoutPlanActivities);

		return Json(new { Success = true, Message = "" });
	}

    public async Task<IActionResult> ShowWorkoutPlan(int workoutPlanId)
    {
        using (logger.BeginScope(GetScopesInformation()))
        {
            logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
                                  new object[] { nameof(ActivityController), nameof(ShowWorkoutPlan), "HttpGet", DateTime.Now.ToString() });

            WorkoutPlanDTO workoutPlan = await _workoutPlanService.GetWorkoutPlanByIdAsync(workoutPlanId);
            return View(workoutPlan);
        }
    }
}
