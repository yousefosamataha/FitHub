using gms.common.Enums;

namespace gms.common.Models.Identity;

public sealed record GymUserDto
{
    public required int UserId { get; init; }

    public required int BranchId { get; init; }

    public required int GymId { get; init; }

    public required byte[]? Image { get; init; }

    public required string FirstName { get; init; }

    public required string LastName { get; init; }

    public required GenderEnum GenderId { get; init; }

    public required string? State { get; init; }

    public required StatusEnum StatusId { get; init; }

    public required GymUserTypeEnum? GymUserTypeId { get; init; }
}
