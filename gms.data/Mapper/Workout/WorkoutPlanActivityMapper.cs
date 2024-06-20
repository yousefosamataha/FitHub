using gms.common.Models.WorkoutCat.WorkoutPlanActivity;
using gms.data.Mapper.Activity;
using gms.data.Models.Workout;

namespace gms.data.Mapper.Workout;

public static class WorkoutPlanActivityMapper
{
	public static WorkoutPlanActivityEntity ToEntity(this CreateWorkoutPlanActivityDTO source)
	{
		return new WorkoutPlanActivityEntity()
		{
			WorkoutPlanId = source.WorkoutPlanId,
			ActivityId = source.ActivityId,
			WeekDayId = source.WeekDayId,
			Sets = source.Sets,
			Reps = source.Reps,
			Kg = source.Kg,
			RestTime = source.RestTime,
		};
	}

	public static WorkoutPlanActivityDTO ToDTO(this WorkoutPlanActivityEntity source)
	{
		return new WorkoutPlanActivityDTO()
		{
			Id = source.Id,
			WorkoutPlanId = source.WorkoutPlanId,
			ActivityId = source.ActivityId,
			WeekDayId = source.WeekDayId,
			Sets = source.Sets,
			Reps = source.Reps,
			Kg = source.Kg,
			RestTime = source.RestTime,
			Activity = source.Activity?.ToDTO()
		};
	}

	public static WorkoutPlanActivityEntity ToUpdatedEntity(this UpdateWorkoutPlanActivityDTO source, WorkoutPlanActivityEntity entity)
	{

		return entity;
	}

}