using gms.common.Models.WorkoutCat.WorkoutPlan;
using gms.data.Models.Workout;

namespace gms.data.Mapper.Workout;

public static class WorkoutPlanMApper
{

	public static WorkoutPlanEntity ToEntity(this CreateWorkoutPlanDTO source)
	{
		return new WorkoutPlanEntity()
		{
		};
	}

	public static WorkoutPlanDTO ToDTO(this WorkoutPlanEntity source)
	{
		return new WorkoutPlanDTO()
		{
		};
	}

	public static WorkoutPlanEntity ToUpdatedEntity(this UpdateWorkoutPlanDTO source, WorkoutPlanEntity entity)
	{

		return entity;
	}
}
