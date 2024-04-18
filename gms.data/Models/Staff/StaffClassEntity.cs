using gms.data.Models.Base;
using gms.data.Models.Class;
using gms.data.Models.Identity;

namespace gms.data.Models.Staff;

public class StaffClassEntity : GymBaseEntity
{
    public int StaffId { get; set; }
    public int ClassScheduleId { get; set; }
    public virtual GymUserEntity GymStaffUser { get; set; }
    public virtual ClassScheduleEntity ClassSchedule { get; set; }
}
