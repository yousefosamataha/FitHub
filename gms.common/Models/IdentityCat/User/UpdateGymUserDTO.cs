using gms.common.Enums;

namespace gms.common.Models.IdentityCat.User;

public record UpdateGymUserDTO
{
    public int Id { get; init; }
    public int BranchId { get; init; }
    public string? Image { get; init; }
    public string? ImageType { get; init; }
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public GenderEnum GenderId { get; init; }
    public DateOnly BirthDate { get; init; }
    public string? Address { get; init; }
    public string? City { get; init; }
    public string? State { get; init; }
    public string? PhoneNumber { get; init; }
    public required string Email { get; init; }
    public required string Password { get; init; }
    public StatusEnum StatusId { get; init; }
    public GymUserTypeEnum? GymUserTypeId { get; set; }
}
