namespace gms.common.Models.GymCat.GymGroup;

public record UpdateGroupDTO
{
    public int Id { get; init; }
    public int BranchId { get; init; }
    public required string Name { get; init; }
    public string? Image { get; init; }
    public string? ImageType { get; init; }
}
