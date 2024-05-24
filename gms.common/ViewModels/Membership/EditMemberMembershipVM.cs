using gms.common.Models.MembershipCat.MemberMembership;
using gms.common.Models.MembershipCat.MembershipPlan;

namespace gms.common.ViewModels.Membership;

public class EditMemberMembershipVM
{
    public MemberMembershipDTO MemberMembershipDTO {  get; set; }
    public UpdateMemberMembershipDTO UpdateMemberMembershipDTO {  get; set; }
    public List<MembershipDTO> MembershipsListDTO { get; set; }

    public decimal PaidAmount { get; init; }
    public decimal MembershipAmount { get; init; }
}
