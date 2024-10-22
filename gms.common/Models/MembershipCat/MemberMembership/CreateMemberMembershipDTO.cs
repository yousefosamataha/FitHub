﻿using gms.common.Enums;

namespace gms.common.Models.MembershipCat.MemberMembership;

public record CreateMemberMembershipDTO
{
	public int GymMembershipPlanId { get; init; }
	public int MemberId { get; init; }
	public StatusEnum MemberShipStatusId { get; init; }
	public StatusEnum PaymentStatusId { get; init; }
	public DateTime JoiningDate { get; init; }
	public DateTime ExpiringDate { get; init; }
}
