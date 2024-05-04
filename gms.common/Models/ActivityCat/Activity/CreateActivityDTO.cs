namespace gms.common.Models.ActivityCat.Activity;

public record CreateActivityDTO
{
    public int BranchId { get; init; }

    public required string Title { get; init; }

    public int ActivityCategoryId { get; init; }
}
