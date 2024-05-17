using gms.common.Enums;
using gms.common.Models.ClassCat.Class;

namespace gms.common.Models.ClassCat.ClassScheduleDay;

public record ClassScheduleDayDTO
{
    public int Id { get; init; }
    public int ClassScheduleId { get; init; }
    public WeekDayEnum WeekDayId { get; init; }

	public ClassDTO? ClassSchedule { get; init; }
}
