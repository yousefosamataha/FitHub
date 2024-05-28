using gms.common.Enums;

namespace gms.common.Models.WorkoutCat.WorkoutPlan;
public sealed record CreateWorkoutPlanDTO
{
	public int BranchId { get; init; }
	public int GymMemberUserId { get; init; }
	public MemberLevelEnum MemberLevelId { get; init; }
	public StatusEnum WorkoutPlanStatusId { get; init; }
	public DateTime StartDate { get; init; }
	public DateTime EndDate { get; init; }
	public int AssignedByGymStaffUserId { get; init; }
	public string? Description { get; init; }
}
