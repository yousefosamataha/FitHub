using gms.common.Enums;
using Microsoft.AspNetCore.Identity;

namespace gms.data.Models.Identity;
public class GymUserEntity : IdentityUser<int>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public GenderEnum GenderId { get; set; }
    public StatusEnum StatusId { get; set; }
    public GymUserTypeEnum? GymUserTypeId { get; set; }
    public DateOnly BirthDate { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }


    // TODO: Add Relation Entities
    //public int GymId { get; set; }
    //public int? GymStaffSpecializationId { get; set; }
    //public virtual ICollection<GymBranchUsersEntity> GymBranchUsers { get; set; }
    //public virtual GymStaffSpecializationEntity? GymStaffSpecialization { get; set; }
    //public virtual GymEntity Gym { get; set; }
    //public int MembershipId { get; set; }
}
