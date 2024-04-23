namespace gms.common.Models.ActivityCategory;

public record struct UpdateActivityCategoryDTO
{
    public int BranchId { get; init; }

    public string Name { get; init; }
}
