using gms.data.Models.Base;
using gms.data.Models.Class;
using gms.data.Models.Identity;
using gms.data.Models.Membership;
using gms.data.Models.Shared;

namespace gms.data.Models.Gym;

public class GymBranchEntity : BaseEntity
{
    public int GymId { get; set; }
    public required string BranchName { get; set; }
    public int StartYear { get; set; }
    public required string Address { get; set; }
    public required string ContactNumber { get; set; }
    public int CountryId { get; set; }
    public required string Email { get; set; }
    public bool IsMainBranch { get; set; }
    public int GeneralSettingId { get; set; }

    // Navigation properties
    public virtual GymEntity Gym { get; set; }
    public virtual CountryEntity Country { get; set; }
    public virtual ICollection<GymUserEntity> GymUsers { get; set; }
    public virtual ICollection<GymSpecializationEntity> GymSpecializations { get; set; }
    public virtual ICollection<GymMembershipPlanEntity> GymMembershipPlans { get; set; }
    public virtual ICollection<ClassScheduleEntity> ClassSchedules { get; set; }
    public virtual ICollection<ClassLocationEntity> ClassLocations { get; set; }
    public virtual ICollection<GymGroupEntity> GymGroups { get; set; }
    // public virtual GymGeneralSettingEntity GeneralSetting { get; set; }
}
