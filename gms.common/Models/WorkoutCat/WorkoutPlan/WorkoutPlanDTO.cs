using gms.common.Enums;
using gms.common.Models.GymCat.Branch;
using gms.common.Models.Identity.User;
using gms.common.Models.WorkoutCat.WorkoutPlanActivity;

namespace gms.common.Models.WorkoutCat.WorkoutPlan;

public record WorkoutPlanDTO
{
    public int Id { get; init; }
    public int BranchId { get; init; }
    public int GymMemberUserId { get; init; }
    public MemberLevelEnum MemberLevelId { get; init; }
    public StatusEnum WorkoutPlanStatusId { get; init; }
    public DateTime StartDate { get; init; }
    public DateTime EndDate { get; init; }
    public int AssignedByGymStaffUserId { get; init; }
    public string? Description { get; init; }
    public GymBranchDTO GymBranch { get; init; }
    public GymUserDTO GymMemberUser { get; init; }
    public GymUserDTO GymStaffUser { get; init; }
    public List<WorkoutPlanActivityDTO> WorkoutPlanActivities { get; init; }
}