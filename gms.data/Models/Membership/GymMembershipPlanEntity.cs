using gms.common.Enums;
using gms.data.Models.Base;

namespace gms.data.Models.Membership;
public class GymMembershipPlanEntity : BaseEntity
{
    public required string MembershipName { get; set; }
    public required string MembershipDuration { get; set; }
    public MembershipLengthTypeEnum MembershipDurationTypeId { get; set; }
    public decimal MembershipAmount { get; set; }
    public StatusEnum MembershipStatusId { get; set; }
    public decimal SignupFee { get; set; }
    public string? MembershipDescription { get; set; }
    public int? InstallmentPlanId { get; set; }
    public decimal? InstallmentAmount { get; set; }

    public ICollection<GymMemberMembershipEntity> GymMemberMemberships { get; set; }

    // TODO: Add Relation Entities
    //public int CreatedById { get; set; } // FK
    //public ICollection<MembershipPlanClass> MembershipPlanClasses { get; set; }
    //public int ClassIsLimit { get; set; }
    //public int ClassLimitDays { get; set; }
    //public int ClassLimitation { get; set; }
}
