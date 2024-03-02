using System.ComponentModel.DataAnnotations;

namespace gms.common.ViewModels;
public sealed class AddRoleViewModel
{
	[Required, StringLength(256)]
	public string RoleName { get; set; }
}
