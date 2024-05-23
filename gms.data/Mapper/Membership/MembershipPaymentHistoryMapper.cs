using gms.common.Models.MembershipCat.MembershipPaymentHistory;
using gms.data.Models.Membership;

namespace gms.data.Mapper.Membership;

public static class MembershipPaymentHistoryMapper
{
    public static GymMembershipPaymentHistoryEntity ToEntity(this CreateMembershipPaymentHistoryDTO source)
    {
        return new GymMembershipPaymentHistoryEntity()
        {
            GymMemberMembershipId = source.GymMemberMembershipId,
            PaidAmount = source.PaidAmount,
            PaymentMethodId = source.PaymentMethodId,
            TransactionId = source.TransactionId,
            PaidDate = source.PaidDate
        };
    }

    public static MembershipPaymentHistoryDTO ToDTO(this GymMembershipPaymentHistoryEntity source)
    {
        return new MembershipPaymentHistoryDTO()
        {
            Id = source.Id,
            GymMemberMembershipId = source.GymMemberMembershipId,
            PaidAmount = source.PaidAmount,
            PaymentMethodId = source.PaymentMethodId,
            TransactionId = source.TransactionId,
            PaidDate = source.PaidDate
        };
    }
}
