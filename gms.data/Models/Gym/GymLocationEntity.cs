using gms.data.Models.Base;
using gms.data.Models.Class;
using gms.data.Models.Event;

namespace gms.data.Models.Gym;

public class GymLocationEntity : BaseEntity
{
    public int BranchId { get; set; }
    public required string Name { get; set; }

    // Navigation properties
    public virtual GymBranchEntity GymBranch { get; set; }
    public virtual ICollection<ClassScheduleEntity> ClassSchedules { get; set; }
    public virtual ICollection<GymEventReservationEntity> GymEventReservations { get; set; }
}
