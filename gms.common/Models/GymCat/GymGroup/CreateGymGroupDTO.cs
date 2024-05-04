namespace gms.common.Models.GymCat.GymGroup;

public record CreateGymGroupDTO
{
    public int BranchId { get; init; }
    public required string Name { get; init; }
    public string? Image { get; init; }
    public string? ImageType { get; init; }
}
