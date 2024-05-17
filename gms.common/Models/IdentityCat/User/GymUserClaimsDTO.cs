using gms.common.Enums;

namespace gms.common.Models.Identity.User;

public sealed record GymUserClaimsDto
{
	public required int UserId { get; init; }

	public required int GymId { get; init; }

	public required int BranchId { get; init; }

	public required string FirstName { get; init; }

	public required string LastName { get; init; }

	public required string Email { get; init; }

	public required GenderEnum GenderId { get; init; }

	public required StatusEnum UserStatusId { get; init; }

	public required GymUserTypeEnum? GymUserTypeId { get; init; }
}