using gms.common.Models.MembershipCat.MemberMembership;
using gms.data.Models.Membership;

namespace gms.data.Mapper.Membership;

public static class MemberMembershipMapper
{
	public static GymMemberMembershipEntity ToEntity(this CreateMemberMembershipDTO source)
	{
		return new GymMemberMembershipEntity()
		{
			GymMembershipPlanId = source.GymMembershipPlanId,
			MemberId = source.MemberId,
			MemberShipStatusId = source.MemberShipStatusId,
			PaymentStatusId = source.PaymentStatusId,
			JoiningDate = source.JoiningDate,
			ExpiringDate = source.ExpiringDate
		};
	}

	public static MemberMembershipDTO ToDTO(this GymMemberMembershipEntity entity)
	{
		return new MemberMembershipDTO()
		{
			Id = entity.Id,
			GymMembershipPlanId = entity.GymMembershipPlanId,
			MemberId = entity.MemberId,
			MemberShipStatusId = entity.MemberShipStatusId,
			PaymentStatusId = entity.PaymentStatusId,
			JoiningDate = entity.JoiningDate,
			ExpiringDate = entity.ExpiringDate,
			PaidAmount = entity.MembershipPaymentHistories is not null ? entity.MembershipPaymentHistories.Sum(mph => mph.PaidAmount) : 0,
            MemberName = entity.GymMemberUser?.FirstName + ' ' + entity.GymMemberUser?.LastName,
			Membership = entity.GymMembershipPlan?.ToDTO()
		};
	}

    public static GymMemberMembershipEntity ToUpdatedEntity(this UpdateMemberMembershipDTO source, GymMemberMembershipEntity entity)
    {
        entity.GymMembershipPlanId = source.GymMembershipPlanId > default(int) && source.GymMembershipPlanId != entity.GymMembershipPlanId ? source.GymMembershipPlanId : entity.GymMembershipPlanId;
        entity.MemberShipStatusId = source.MemberShipStatusId;
        entity.PaymentStatusId = source.PaymentStatusId;
        entity.JoiningDate = source.JoiningDate;
        entity.ExpiringDate = source.ExpiringDate;
    
        return entity;
    }
}
