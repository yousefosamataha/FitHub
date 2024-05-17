namespace gms.common.Models.GymCat.GymLocation;

public record GymLocationDTO
{
    public int Id { get; init; }
    public int BranchId { get; init; }
    public required string Name { get; init; }
}
