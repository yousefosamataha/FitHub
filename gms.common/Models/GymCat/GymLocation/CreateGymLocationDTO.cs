namespace gms.common.Models.GymCat.GymLocation;

public record CreateGymLocationDTO
{
    public int BranchId { get; init; }
    public required string Name { get; init; }
}
