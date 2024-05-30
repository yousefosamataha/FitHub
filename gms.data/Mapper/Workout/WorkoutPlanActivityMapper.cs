using gms.common.Models.WorkoutCat.WorkoutPlanActivity;
using gms.data.Models.Workout;

namespace gms.data.Mapper.Workout;

public static class WorkoutPlanActivityMapper
{
	public static WorkoutPlanActivityEntity ToEntity(this CreateWorkoutPlanActivityDTO source)
	{
		return new WorkoutPlanActivityEntity()
		{
		};
	}

	public static WorkoutPlanActivityDTO ToDTO(this WorkoutPlanActivityEntity source)
	{
		return new WorkoutPlanActivityDTO()
		{
		};
	}

	public static WorkoutPlanActivityEntity ToUpdatedEntity(this UpdateWorkoutPlanActivityDTO source, WorkoutPlanActivityEntity entity)
	{

		return entity;
	}

}