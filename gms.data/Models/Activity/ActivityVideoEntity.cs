using gms.data.Models.Base;

namespace gms.data.Models.Activity;
public class ActivityVideoEntity : BaseEntity
{
    public required string VideoPath { get; set; }

    //TODO: Add Relation Entities 
    //public int ActivityId { get; set; } // FK
    //public int CreatedById { get; set; } // FK
}
