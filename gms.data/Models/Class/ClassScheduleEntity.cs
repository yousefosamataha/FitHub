using gms.data.Models.Base;

namespace gms.data.Models.Class;

public class ClassScheduleEntity : BaseEntity
{
    public required string ClassName { get; set; }
    public int ClassLocationId { get; set; }
    public decimal ClassFees { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public virtual ClassLocationEntity ClassLocation { get; set; }
    public virtual ICollection<ClassScheduleDayEntity> ClassScheduleDays { get; set; }

    // TODO: Add Relation Entities
    // public virtual ICollection<StaffClassEntity> StaffClasses { get; set; }

    // TODO: Add Relation Entities
    // public int CreatedById { get; set; }
}
