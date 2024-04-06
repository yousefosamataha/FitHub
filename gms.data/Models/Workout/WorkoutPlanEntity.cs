using gms.common.Enums;
using gms.data.Models.Base.Entities;

namespace gms.data.Models.Workout;

public class WorkoutPlanEntity : BaseEntity
{
	public MemberLevelEnum MemberLevelId { get; set; } 
	public DateTime StartDate { get; set; }
	public DateTime EndDate { get; set; }
	public string? Description { get; set; }

	public virtual ICollection<WorkoutPlanActivityEntity> WorkoutPlanActivities { get; set; }

	// TODO: Add Relation Entities
	// public int MemberId { get; set; }
	// public int AssignedById { get; set; }
	// public int CreatedById { get; set; }
}
