using gms.common.Enums;

namespace gms.common.Models.IdentityCat;

public class CreateGymUserDTO
{
	public int? BranchId { get; set; }
	public string? Image { get; set; }
    public string? ImageType { get; set; }
    public string? FirstName { get; set; }
	public string? LastName { get; set; }
	public GenderEnum? GenderId { get; set; }
	public DateOnly? BirthDate { get; set; }
	public string? Address { get; set; }
	public string? City { get; set; }
	public string? State { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public StatusEnum? StatusId { get; set; }
	public GymUserTypeEnum? GymUserTypeId { get; set; }
}
