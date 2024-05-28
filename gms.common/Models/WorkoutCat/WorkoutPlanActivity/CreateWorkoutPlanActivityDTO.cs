using gms.common.Enums;

namespace gms.common.Models.WorkoutCat.WorkoutPlanActivity;

public sealed record CreateWorkoutPlanActivityDTO
{
	public int WorkoutPlanId { get; init; }
	public int ActivityId { get; init; }
	public WeekDayEnum WeekDayId { get; init; }
	public int Sets { get; init; }
	public int Reps { get; init; }
	public double Kg { get; init; }
	public TimeSpan RestTime { get; init; }
}