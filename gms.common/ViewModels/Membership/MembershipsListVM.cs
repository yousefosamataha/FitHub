﻿using gms.common.Models.MembershipCat.MembershipPlan;

namespace gms.common.ViewModels.Membership;

public class MembershipsListVM
{
    public List<MembershipDTO> MembershipsList { get; set; }
    public string BranchCurrencySymbol { get; set; }
}
