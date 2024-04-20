using gms.data.Models.Base;
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
    public virtual GymGeneralSettingEntity GeneralSetting { get; set; }
    public virtual ICollection<GymBranchUsersEntity> GymBranchUsers { get; set; }
    public virtual ICollection<GymMembershipPlanEntity> GymMembershipPlans { get; set; }
    public virtual ICollection<GymMemberMembershipEntity> GymMemberMemberships { get; set; }
    //public virtual ICollection<GymMembershipPaymentHistoryEntity> MembershipPaymentHistories { get; set; }
    //public virtual ICollection<GymSpecializationEntity> GymBranchSpecializations { get; set; }
}
