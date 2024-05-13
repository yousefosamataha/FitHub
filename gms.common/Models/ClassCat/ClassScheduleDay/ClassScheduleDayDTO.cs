using gms.common.Enums;

namespace gms.common.Models.ClassCat.ClassScheduleDay;

public record ClassScheduleDayDTO
{
    public int Id { get; init; }
    public int ClassScheduleId { get; init; }
    public WeekDayEnum WeekDayId { get; init; }
}
