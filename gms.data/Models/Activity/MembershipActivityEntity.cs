using gms.data.Models.Base;

namespace gms.data.Models.Activity;
public class MembershipActivityEntity : BaseEntity
{
    public int ActivityId { get; set; }
    public virtual ActivityEntity Activity { get; set; }

    //TODO: Add Relation Entities 
    //public int CreatedById { get; set; }
    //public int MembershipId { get; set; }
    //public Membership Membership { get; set; }
    //public GymUser CreatedBy { get; set; }
}
