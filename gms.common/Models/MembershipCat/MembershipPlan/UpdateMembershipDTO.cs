﻿using gms.common.Enums;

namespace gms.common.Models.MembershipCat.MembershipPlan;

public record UpdateMembershipDTO
{
    public int Id { get; init; }
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
}
