namespace gms.common.Models.Activity;

public record struct CreateActivityDTO
{
	public int BranchId { get; set; }

	public required string Title { get; set; }

	public int ActivityCategoryId { get; set; }
}
