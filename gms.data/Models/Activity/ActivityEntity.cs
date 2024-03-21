using gms.data.Models.Base;

namespace gms.data.Models.Activity;
public class ActivityEntity : BaseEntity
{
    public required string Title { get; set; }
    public int ActivityCategoryId { get; set; }
    public virtual ActivityCategoryEntity ActivityCategory { get; set; }
    public virtual ICollection<ActivityVideoEntity> ActivityVideos { get; set; }
    public virtual ICollection<MembershipActivityEntity> MembershipActivities { get; set; }

    //TODO: Add Relation Entities
    //public int? AssignedTo { get; set; }
    //public int CreatedById { get; set; } // FK
}
