namespace gms.common.Models.ActivityCategory;

public record struct CreateActivityCategoryDTO
{
    public int BranchId { get; init; }

    public required string Name { get; init; }
}