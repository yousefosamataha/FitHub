using gms.common.Enums;
using gms.data.Models.Base;

namespace gms.data.Models.Membership;
public class GymMembershipPlanEntity : BaseEntity
{
    public required string MembershipName { get; set; }
    public int MembershipDuration { get; set; }
    public MembershipLengthTypeEnum MembershipDurationTypeId { get; set; }
    public decimal MembershipAmount { get; set; }
    public StatusEnum MembershipStatusId { get; set; }
    public decimal SignupFee { get; set; }
    public string? MembershipDescription { get; set; }
    public bool ClassIsLimit { get; set; }
    public int? ClassLimitDays { get; set; }
    public MembershipClassLimitationEnum? ClassLimitationId { get; set; }
    public int CreatedById { get; set; }

    // Navigation properties
    // public virtual GymUserEntity GymStaffUser { get; set; }
    public virtual ICollection<GymMemberMembershipEntity> GymMemberMemberships { get; set; }
    public ICollection<GymMembershipPlanClassEntity> MembershipPlanClasses { get; set; }

    // TODO: Add Relation Entities
    // public int? InstallmentPlanId { get; set; }
    // public decimal? InstallmentAmount { get; set; }
}
