using gms.common.Enums;
using Microsoft.AspNetCore.Identity;

namespace gms.data.Models.Identity;
public class GymUserEntity : IdentityUser
{
    public int GymId { get; set; }
    public int GymBranchId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public GenderEnum GenderId { get; set; }
    public StatusEnum StatusId { get; set; }
    public DateOnly BirthDate { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }

    //public int MembershipId { get; set; }
    //public int? SpecializationId { get; set; }
    //public GymStaffSpecialization Specialization { get; set; }
}
