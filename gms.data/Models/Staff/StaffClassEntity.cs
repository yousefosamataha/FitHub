using gms.data.Models.Base.Entities;
using gms.data.Models.Class;

namespace gms.data.Models.Staff;

public class StaffClassEntity : BaseEntity
{
    public int ClassId { get; set; }
    public virtual ClassScheduleEntity ClassSchedule { get; set; }

    // TODO: Add Relation Entities
    // public int StaffId { get; set; }
}
