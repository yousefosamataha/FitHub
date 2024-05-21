using gms.common.Models.MembershipCat.MemberMembership;

namespace gms.common.ViewModels.Membership;

public class MembershipPaymentVM
{
    public List<MemberMembershipDTO> MemberMembershipList { get; set; }
    public string BranchCurrencySymbol { get; set; }
}
