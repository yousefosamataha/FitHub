using gms.data.Models.Base;
using gms.data.Models.Gym;

namespace gms.data.Models.Activity;
public class ActivityCategoryEntity : BaseEntity
{
	public int BranchId { get; set; }

	public required string Name { get; set; }

	// Navigation properties
	public virtual GymBranchEntity GymBranch { get; set; }

	public virtual ICollection<ActivityEntity> Activities { get; set; }
}
