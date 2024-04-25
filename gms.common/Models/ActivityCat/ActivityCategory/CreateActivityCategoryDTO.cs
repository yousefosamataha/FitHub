namespace gms.common.Models.ActivityCat.ActivityCategory;

public record struct CreateActivityCategoryDTO
{
    public int BranchId { get; init; }

    public required string Name { get; init; }
}