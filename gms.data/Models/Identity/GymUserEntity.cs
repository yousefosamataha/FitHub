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
    public GymUserTypeEnum? GymUserTypeId { get; set; }
    public DateOnly BirthDate { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }

    // TODO: Add Relation Entities
    //public int GymStaffSpecializationId { get; set; }
    //public virtual GymStaffSpecializationEntity GymStaffSpecialization { get; set; }
    //public int MembershipId { get; set; }
}
