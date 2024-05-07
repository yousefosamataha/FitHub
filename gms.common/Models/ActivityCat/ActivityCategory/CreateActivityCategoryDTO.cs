namespace gms.common.Models.ActivityCat.ActivityCategory;

public record CreateActivityCategoryDTO
{
    public int BranchId { get; init; }

    public required string Name { get; init; }
}