namespace gms.common.Models.ActivityCat.ActivityCategory;

public record ActivityCategoryDTO
{
    public required int Id { get; init; }

    public int BranchId { get; init; }

    public required string Name { get; init; }
}