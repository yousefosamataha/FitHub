using gms.common.Models.ActivityCat.Activity;
using gms.common.Models.ActivityCat.ActivityCategory;
using gms.common.Models.MembershipCat.MembershipPlan;

namespace gms.common.ViewModels.Activity;

public class UpdateActivityVM
{
	public UpdateActivityDTO Activity { get; set; }
	public List<ActivityCategoryDTO> ActivityCategories { get; set; }
	public List<MembershipDTO> Memberships { get; set; }
    public List<int> MembershipIds { get; set; }
	public List<string> ActivityVideos { get; set; }
}
