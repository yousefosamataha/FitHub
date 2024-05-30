using gms.data.Models.Gym;
using Microsoft.AspNetCore.Identity;

namespace gms.data.Models.Identity;
public class GymIdentityRoleEntity : IdentityRole<int>
{
	public int BranchId { get; set; }

	public virtual GymBranchEntity GymBranch { get; set; }

	public bool IsDeleted { get; set; }

	public bool IsDeleteable { get; set; }

	public bool IsUpdateable { get; set; }
}
