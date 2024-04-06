using gms.data.Models.Base.Entities;

namespace gms.data.Models.Activity;
public class ActivityCategoryEntity : GymBaseEntity
{
    public string Name { get; set; }
    public virtual ICollection<ActivityEntity> Activities { get; set; }
}
