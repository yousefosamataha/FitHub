using gms.data.Models.Base.Entities;

namespace gms.data.Models.Event;
public class GymEventPlaceEntity : BaseEntity
{
    public required string PlaceName { get; set; }
    public virtual ICollection<GymEventReservationEntity> GymEventReservations { get; set; }

    // TODO: Add Relation Entities
    //public int CreatedById { get; set; }
    //public GymUser CreatedBy { get; set; } // Assuming a GymUser entity represents the user who created the event place
}
