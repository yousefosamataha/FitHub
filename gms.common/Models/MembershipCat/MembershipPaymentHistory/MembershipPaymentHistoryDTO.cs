using gms.common.Enums;

namespace gms.common.Models.MembershipCat.MembershipPaymentHistory;

public record MembershipPaymentHistoryDTO
{
    public int Id { get; init; }
    public int GymMemberMembershipId { get; init; }
    public decimal PaidAmount { get; init; }
    public PaymentMethodEnum PaymentMethodId { get; init; }
    public string? TransactionId { get; init; }
    public DateTime PaidDate { get; init; }
}
