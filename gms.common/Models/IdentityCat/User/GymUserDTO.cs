using gms.common.Enums;
using gms.common.Models.GymCat.GymMemberGroup;
using gms.common.Models.GymCat.GymStaffGroup;
using gms.common.Models.GymCat.GymStaffSpecialization;
using gms.common.Models.MembershipCat.MemberMembership;

namespace gms.common.Models.Identity.User;

public sealed record GymUserDTO
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
    public string? Password { get; init; }
    public StatusEnum StatusId { get; init; }
    public GymUserTypeEnum? GymUserTypeId { get; set; }
    public string Roles { get; set; }
    public string RoleName { get; set; }

    public MemberMembershipDTO GymMemberMembership { get; set; }
    public ICollection<GymMemberGroupDTO> GymMemberGroups { get; set; }
    public ICollection<GymStaffGroupDTO> GymStaffGroups { get; set; }
    public ICollection<GymStaffSpecializationDTO> GymStaffSpecializations { get; set; }
}
