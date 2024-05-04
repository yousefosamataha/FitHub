namespace gms.common.Models.ActivityCat.Activity;

public record ActivityDTO
{
    public required int ActivityId { get; init; }

    public int BranchId { get; init; }

    public required string Title { get; init; }

    public int ActivityCategoryId { get; init; }
}
