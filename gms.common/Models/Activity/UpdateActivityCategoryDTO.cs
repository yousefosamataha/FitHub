namespace gms.common.Models.Activity;

public record struct UpdateActivityCategoryDTO
{
	public int BranchId { get; init; }

	public string Name { get; init; }
}
