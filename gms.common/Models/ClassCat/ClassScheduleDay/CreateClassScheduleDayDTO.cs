using gms.common.Enums;

namespace gms.common.Models.ClassCat.ClassScheduleDay;

public record CreateClassScheduleDayDTO
{
    public int ClassScheduleId { get; init; }
    public WeekDayEnum WeekDayId { get; init; }
}
