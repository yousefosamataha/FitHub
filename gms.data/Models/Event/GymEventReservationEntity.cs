using gms.data.Models.Base;
using gms.data.Models.Gym;

namespace gms.data.Models.Event;
public class GymEventReservationEntity : BaseEntity
{
    public int BranchId { get; set; }
    public required string EventName { get; set; }
    public DateTime EventDate { get; set; }
    public int GymLocationId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }

    // Navigation properties
    public virtual GymBranchEntity GymBranch { get; set; }
    public virtual GymLocationEntity GymLocation { get; set; }
}
