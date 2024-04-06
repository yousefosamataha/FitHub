using gms.data.Models.Base.Entities;

namespace gms.data.Models.Activity;
public class ActivityVideoEntity : BaseEntity
{
    public required string VideoPath { get; set; }
    public int ActivityId { get; set; }
    public virtual ActivityEntity Activity { get; set; }

    //TODO: Add Relation Entities 
    //public int CreatedById { get; set; } // FK
}
