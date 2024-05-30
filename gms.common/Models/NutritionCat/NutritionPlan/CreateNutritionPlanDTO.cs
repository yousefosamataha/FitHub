using gms.common.Enums;
using gms.common.Models.GymCat.Branch;
using gms.common.Models.Identity.User;

namespace gms.common.Models.NutritionCat.NutritionPlan;

public sealed record CreateNutritionPlanDTO
{
	public int BranchId { get; set; }

	public int GymMemberUserId { get; set; }

	public StatusEnum NutritionPlanStatusId { get; set; }

	public DateTime StartDate { get; set; }

	public DateTime EndDate { get; set; }

	public int AssignedByGymStaffUserId { get; set; }

	public string? Description { get; set; }
}
public sealed record UpdateNutritionPlanDTO
{

}
public sealed record NutritionPlanDTO
{
	public int Id { get; set; }

	public int BranchId { get; set; }

	public int GymMemberUserId { get; set; }

	public StatusEnum NutritionPlanStatusId { get; set; }

	public DateTime StartDate { get; set; }

	public DateTime EndDate { get; set; }

	public int AssignedByGymStaffUserId { get; set; }

	public string? Description { get; set; }

	public GymBranchDTO GymBranch { get; set; }

	public GymUserDTO GymMemberUser { get; set; }

	public GymUserDTO GymStaffUser { get; set; }
	//public virtual ICollection<NutritionPlanMealEntity> NutritionPlanMeals { get; set; }
}