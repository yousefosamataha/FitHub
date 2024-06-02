using gms.common.Enums;
using gms.data.Models.Base;
using gms.data.Models.Gym;
using gms.data.Models.Identity;

namespace gms.data.Models.Nutrition;

public class NutritionPlanEntity : BaseEntity
{
	public int BranchId { get; set; }
	public int GymMemberUserId { get; set; }
	public StatusEnum NutritionPlanStatusId { get; set; }
	public DateTime StartDate { get; set; }
	public DateTime EndDate { get; set; }
	public int AssignedByGymStaffUserId { get; set; }
	public string? Description { get; set; }

	// Navigation properties
	public virtual GymBranchEntity GymBranch { get; set; }
	public virtual GymUserEntity GymMemberUser { get; set; }
	public virtual GymUserEntity GymStaffUser { get; set; }
	public virtual ICollection<NutritionPlanMealEntity> NutritionPlanMeals { get; set; }
}
