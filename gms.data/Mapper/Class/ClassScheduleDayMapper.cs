using gms.common.Models.ClassCat.ClassScheduleDay;
using gms.data.Models.Class;

namespace gms.data.Mapper.Class;

public static class ClassScheduleDayMapper
{
    public static ClassScheduleDayEntity ToEntity(this CreateClassScheduleDayDTO source)
    {
        return new ClassScheduleDayEntity()
        {
            ClassScheduleId = source.ClassScheduleId,
            WeekDayId = source.WeekDayId
        };
    }

    public static ClassScheduleDayDTO ToDTO(this ClassScheduleDayEntity source)
    {
        return new ClassScheduleDayDTO()
        {
            Id = source.Id,
            ClassScheduleId = source.ClassScheduleId,
            WeekDayId = source.WeekDayId
        };
    }
}
