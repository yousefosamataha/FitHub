using gms.data.Models.Base;
using gms.data.Models.Gym;
using gms.data.Models.Workout;

namespace gms.data.Models.Activity;

public class ActivityEntity : BaseEntity
{
	public int BranchId { get; set; }
	public required string Title { get; set; }
	public int ActivityCategoryId { get; set; }

	// Navigation properties
	public virtual GymBranchEntity GymBranch { get; set; }

	public virtual ICollection<MembershipActivityEntity> MembershipActivities { get; set; }

	public virtual ICollection<ActivityVideoEntity> ActivityVideos { get; set; }

	public virtual ActivityCategoryEntity ActivityCategory { get; set; }

	public virtual ICollection<WorkoutPlanActivityEntity> WorkoutPlanActivities { get; set; }
}
