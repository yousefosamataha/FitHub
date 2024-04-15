namespace gms.common.ViewModels;
public sealed class GymUserRolesViewModel
{
	public int UserId { get; set; }
	public string UserName { get; set; }
	public string Email { get; set; }
	public List<SelectItemViewModel> Roles { get; set; }
}
