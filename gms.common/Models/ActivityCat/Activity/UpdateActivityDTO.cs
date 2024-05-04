namespace gms.common.Models.ActivityCat.Activity;
public record struct UpdateActivityDTO
{
    public int BranchId { get; init; }

    public string Title { get; init; }

    public int ActivityCategoryId { get; init; }
}
