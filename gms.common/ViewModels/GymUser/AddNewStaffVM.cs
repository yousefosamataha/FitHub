using gms.common.Models.GymCat.GymGroup;
using gms.common.Models.GymCat.GymSpecialization;
using gms.common.Models.Identity.Role;
using gms.common.Models.Identity.User;

namespace gms.common.ViewModels.GymUser;

public class AddNewStaffVM
{
	public CreateGymUserDTO CreateStaffDTO { get; set; }
	public List<GymGroupDTO> GymGroupsListDTO { get; set; }
	public List<GymRoleDTO> Roles { get; set; }
	public List<GymSpecializationDTO> GymSpecializationsListDTO { get; set; }
	public List<int> SelectedGroupIds { get; set; }
	public List<int> SelectedSpecializationIds { get; set; }
	public string RoleName { get; set; }
}
