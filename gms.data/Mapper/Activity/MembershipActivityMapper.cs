using gms.common.Models.ActivityCat.MembershipActivity;
using gms.data.Models.Activity;

namespace gms.data.Mapper.Activity;

public static class MembershipActivityMapper
{
	public static MembershipActivityEntity ToEntity(this CreateMembershipActivityDTO source)
	{
		return new MembershipActivityEntity()
		{
			ActivityId = source.ActivityId,
			MembershipPlanId = source.MembershipPlanId,
		};
	}
}
