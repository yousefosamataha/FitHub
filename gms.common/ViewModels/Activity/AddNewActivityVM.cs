using gms.common.Models.ActivityCat.Activity;
using gms.common.Models.ActivityCat.ActivityCategory;
using gms.common.Models.MembershipCat;

namespace gms.common.ViewModels.Activity;

public class AddNewActivityVM
{
	public CreateActivityDTO Activity { get; set; }
	public List<ActivityCategoryDTO> ActivityCategories { get; set; }
	public List<MembershipDTO> Memberships { get; set; }
	public List<int> MembershipIds { get; set; }
}
