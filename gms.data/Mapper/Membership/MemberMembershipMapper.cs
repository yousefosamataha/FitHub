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
			ExpiringDate = entity.ExpiringDate
		};
	}

}
