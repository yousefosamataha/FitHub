using gms.data.Models.Base;

namespace gms.data.Models.Activity;
public class ActivityCategoryEntity : BaseEntity
{
    public string Name { get; set; }
    public virtual ICollection<ActivityEntity> Activities { get; set; }
}
