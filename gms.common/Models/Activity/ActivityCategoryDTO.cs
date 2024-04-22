namespace gms.common.Models.Activity;

public record struct ActivityCategoryDTO
{
	public required int ActivityCategoryId { get; init; }

	public int BranchId { get; init; }

	public required string Name { get; init; }

	public List<ActivityDTO> Activities { get; init; }
}