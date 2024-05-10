namespace gms.common.Models.ActivityCat.Activity;
public record UpdateActivityDTO
{
    public int Id { get; init; }

    public int BranchId { get; init; }

    public string Title { get; init; }

    public int ActivityCategoryId { get; init; }
}
