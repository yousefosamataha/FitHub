using gms.common.Models.ActivityCat.ActivityCategory;

namespace gms.common.Models.ActivityCat.Activity;

public record ActivityDTO
{
    public required int Id { get; init; }

    public int BranchId { get; init; }

    public required string Title { get; init; }

    public int ActivityCategoryId { get; init; }

    public ActivityCategoryDTO? ActivityCategory { get; init; }
}
