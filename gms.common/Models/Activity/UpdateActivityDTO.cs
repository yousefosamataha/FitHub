namespace gms.common.Models.Activity;
public record struct UpdateActivityDTO
{
	public int BranchId { get; set; }

	public string Title { get; set; }

	public int ActivityCategoryId { get; set; }
}
