namespace gms.common.ViewModels;
public sealed class GymRolePermissionsViewModel
{
	public int RoleId { get; set; }
	public string RoleName { get; set; }
	public List<SelectItemViewModel> Permissions { get; set; }
}
