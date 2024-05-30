using gms.common.Models.GymCat.Branch;

namespace gms.common.Models.NutritionCat.MealTime;

public sealed record CreateMealTimeDTO
{
	public int BranchId { get; set; }
	public string Name { get; set; }
}

public sealed record UpdateMealTimeDTO
{

}

public sealed record MealTimeDTO
{
	public int Id { get; set; }

	public int BranchId { get; set; }

	public string Name { get; set; }

	public GymBranchDTO GymBranch { get; set; }
}