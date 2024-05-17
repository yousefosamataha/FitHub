using gms.common.Models.GymCat.GymGroup;
using gms.common.Models.Identity.User;
using gms.common.Models.MembershipCat.MemberMembership;
using gms.common.Models.MembershipCat.MembershipPlan;

namespace gms.common.ViewModels.GymUser;

public class AddNewMemberVM
{
    public CreateGymUserDTO CreateMemberDTO {  get; set; }
    public CreateMemberMembershipDTO MemberMembershipDTO {  get; set; }
    public List<GymGroupDTO> GymGroupsListDTO {  get; set; }
    public List<MembershipDTO> MembershipsListDTO {  get; set; }
    public List<int> SelectedGroupIds { get; set; }
}
