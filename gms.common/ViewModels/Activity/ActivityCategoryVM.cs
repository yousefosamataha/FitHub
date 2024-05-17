using gms.common.Models.ActivityCat.ActivityCategory;

namespace gms.common.ViewModels.Activity;

public class ActivityCategoryVM
{
    public CreateActivityCategoryDTO CreateActivityCategory { get; set; }
    public ActivityCategoryDTO ActivityCategory { get; set; }
    public List<ActivityCategoryDTO> ActivityCategoryList { get; set; }
}
