﻿using gms.common.Enums;
using gms.common.Models.MembershipCat.MembershipPlan;

namespace gms.common.Models.MembershipCat.MemberMembership;

public record MemberMembershipDTO
{
	public int Id { get; init; }
	public int GymMembershipPlanId { get; init; }
	public int MemberId { get; init; }
	public StatusEnum MemberShipStatusId { get; init; }
	public StatusEnum PaymentStatusId { get; init; }
	public DateTime JoiningDate { get; init; }
	public DateTime ExpiringDate { get; init; }

	public string? MemberName { get; init; }
	public decimal PaidAmount { get; init; }
	public MembershipDTO Membership { get; init; }
}