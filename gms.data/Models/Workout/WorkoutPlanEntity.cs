using gms.common.Enums;
using gms.data.Models.Base;

namespace gms.data.Models.Workout;

public class WorkoutPlanEntity : BaseEntity
{
	public MemberLevelEnum MemberLevelId { get; set; } 
	public DateTime StartDate { get; set; }
	public DateTime EndDate { get; set; }
	public string? Description { get; set; }

	// TODO: Add Relation Entities
	// public int MemberId { get; set; }
	// public int AssignedById { get; set; }
	// public int CreatedById { get; set; }
	// public ICollection<WorkoutPlanActivity> WorkoutPlanActivities { get; set; }
}
