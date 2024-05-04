using gms.common.Enums;

namespace gms.common.Models.Identity;

public sealed record GymUserDTO
{
	public int? Id { get; init; }
	public int? BranchId { get; init; }
	public string? Image { get; init; }
	public string? ImageType { get; init; }
	public string? FirstName { get; init; }
	public string? LastName { get; init; }
	public GenderEnum? GenderId { get; init; }
	public DateOnly? BirthDate { get; init; }
	public string? Address { get; init; }
	public string? City { get; init; }
	public string? State { get; init; }
    public string? PhoneNumber { get; init; }
    public string? Email { get; init; }
    public string? Password { get; init; }
    public StatusEnum? StatusId { get; init; }
	public GymUserTypeEnum? GymUserTypeId { get; init; }
}
