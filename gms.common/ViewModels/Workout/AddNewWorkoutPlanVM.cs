using gms.common.Models.ActivityCat.Activity;
using gms.common.Models.Identity.User;
using gms.common.Models.WorkoutCat.WorkoutPlan;
using gms.common.Models.WorkoutCat.WorkoutPlanActivity;

namespace gms.common.ViewModels.Workout;

public class AddNewWorkoutPlanVM
{
	public List<GymUserDTO> GymMembersList { get; set; }
	public List<ActivityDTO> ActivitiesList { get; set; }

	public CreateWorkoutPlanDTO CreateWorkoutPlan { get; set; }
	public List<CreateWorkoutPlanActivityDTO> CreateWorkoutPlanActivities { get; set; }
}
