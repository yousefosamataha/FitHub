using gms.common.Enums;

namespace gms.common.Models.MembershipCat.MemberMembership;

public record UpdateMemberMembershipDTO
{
    public int Id { get; init; }
    public int GymMembershipPlanId { get; init; }
    public StatusEnum MemberShipStatusId { get; init; }
    public StatusEnum PaymentStatusId { get; init; }
}
