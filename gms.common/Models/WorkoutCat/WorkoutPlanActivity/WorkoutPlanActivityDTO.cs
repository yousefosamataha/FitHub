using gms.common.Enums;
using gms.common.Models.ActivityCat.Activity;
using gms.common.Models.WorkoutCat.WorkoutPlan;

namespace gms.common.Models.WorkoutCat.WorkoutPlanActivity;
public record WorkoutPlanActivityDTO
{
    public int Id { get; init; }
    public int WorkoutPlanId { get; init; }
    public int ActivityId { get; init; }
    public WeekDayEnum WeekDayId { get; init; }
    public int Sets { get; init; }
    public int Reps { get; init; }
    public double Kg { get; init; }
    public TimeSpan RestTime { get; init; }
    public WorkoutPlanDTO WorkoutPlan { get; init; }
    public ActivityDTO Activity { get; init; }
}
