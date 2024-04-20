using gms.common.Enums;
using gms.data.Models.Base;

namespace gms.data.Models.Class;

public class ClassScheduleDayEntity : BaseEntity
{
    public int ClassScheduleId { get; set; }
    public WeekDayEnum WeekDayId { get; set; }

    // Navigation properties
    public virtual ClassScheduleEntity ClassSchedule { get; set; }
}
