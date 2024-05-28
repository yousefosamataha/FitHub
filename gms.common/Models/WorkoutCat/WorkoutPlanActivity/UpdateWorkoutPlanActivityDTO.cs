using gms.common.Enums;

namespace gms.common.Models.WorkoutCat.WorkoutPlanActivity;
public sealed record UpdateWorkoutPlanActivityDTO
{
	public int Id { get; set; }
	public WeekDayEnum WeekDayId { get; set; }
	public int Sets { get; set; }
	public int Reps { get; set; }
	public double Kg { get; set; }
	public TimeSpan RestTime { get; set; }
}
