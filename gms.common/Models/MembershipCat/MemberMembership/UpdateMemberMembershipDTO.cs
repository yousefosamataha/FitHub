using gms.common.Enums;

namespace gms.common.Models.MembershipCat.MemberMembership;

public record UpdateMemberMembershipDTO
{
    public int Id { get; init; }
    public int GymMembershipPlanId { get; init; }
    public StatusEnum MemberShipStatusId { get; set; }
    public StatusEnum PaymentStatusId { get; set; }
    public DateTime JoiningDate { get; init; }
    public DateTime ExpiringDate { get; init; }
}
