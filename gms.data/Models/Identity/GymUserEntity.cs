using gms.common.Enums;
using gms.data.Models.Gym;
using Microsoft.AspNetCore.Identity;

namespace gms.data.Models.Identity;
public class GymUserEntity : IdentityUser<int>
{
    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public GenderEnum GenderId { get; set; }

    public StatusEnum StatusId { get; set; }

    public GymUserTypeEnum? GymUserTypeId { get; set; }

    public DateOnly BirthDate { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public int GymId { get; set; }
    public virtual GymEntity Gym { get; set; }

    public virtual ICollection<GymStaffSpecializationEntity> GymStaffSpecializations { get; set; }

    public virtual ICollection<GymBranchUsersEntity> GymBranchUsers { get; set; }
    // TODO: Add Relation Entities
    //public int MembershipId { get; set; }
}
