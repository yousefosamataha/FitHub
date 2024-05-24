using gms.common.Models.GymCat.GymGroup;
using gms.common.Models.Identity.User;
using gms.common.Models.IdentityCat.User;
using gms.common.Models.MembershipCat.MemberMembership;
using gms.common.Models.MembershipCat.MembershipPlan;

namespace gms.common.ViewModels.GymUser;

public class UpdateMemberVM
{
    public GymUserDTO MemberDTO { get; set; }
    public UpdateGymUserDTO UpdateMemberDTO { get; set; }
    public MemberMembershipDTO MemberMembershipDTO { get; set; }
    public UpdateMemberMembershipDTO UpdateMemberMembershipDTO { get; set; }
    public List<GymGroupDTO> GymGroupsListDTO { get; set; }
    public List<MembershipDTO> MembershipsListDTO { get; set; }
    public List<int> SelectedGroupIds { get; set; }
}
