using gms.data.Models.Base.Entities;

namespace gms.data.Models.Event;
public class GymEventReservationEntity : BaseEntity
{
    public string EventName { get; set; }
    public DateTime EventDate { get; set; }
    public int GymEventPlaceId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public virtual GymEventPlaceEntity GymEventPlace { get; set; }

    // TODO: Add Relation Entities
    //public int CreatedById { get; set; }
    //public GymUser CreatedBy { get; set; } // Assuming a GymUser entity represents the user who created the reservation

}
