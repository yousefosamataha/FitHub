using gms.common.Models.ClassCat.Class;
using gms.data.Mapper.Gym;
using gms.data.Models.Class;

namespace gms.data.Mapper.Class;

public static class ClassMapper
{
    public static ClassScheduleEntity ToEntity(this CreateClassDTO source)
    {
        return new ClassScheduleEntity()
        {
            BranchId = source.BranchId,
            ClassName = source.ClassName,
            GymLocationId = source.GymLocationId,
            ClassFees = source.ClassFees,
            StartTime = source.StartTime,
            EndTime = source.EndTime,
        };
    }

    public static ClassDTO ToDTO(this ClassScheduleEntity source)
    {
        return new ClassDTO()
        {
            Id = source.Id,
            BranchId = source.BranchId,
            ClassName = source.ClassName,
            GymLocationId = source.GymLocationId,
            ClassFees = source.ClassFees,
            StartTime = source.StartTime,
            EndTime = source.EndTime,
            GymLocation = source.GymLocation?.ToDTO()
        };
    }

    public static UpdateClassDTO ToUpdateDTO(this ClassDTO source)
    {
        return new UpdateClassDTO()
        {
            Id = source.Id,
            BranchId = source.BranchId,
            ClassName = source.ClassName,
            GymLocationId = source.GymLocationId,
            ClassFees = source.ClassFees,
            StartTime = source.StartTime,
            EndTime = source.EndTime,
        };
    }

    public static ClassScheduleEntity ToUpdatedEntity(this UpdateClassDTO source, ClassScheduleEntity entity)
    {
        entity.ClassName = !string.IsNullOrWhiteSpace(source.ClassName) && !string.Equals(source.ClassName, entity.ClassName, StringComparison.OrdinalIgnoreCase) ? source.ClassName : entity.ClassName;
        entity.GymLocationId = source.GymLocationId > default(int) && source.GymLocationId != entity.GymLocationId ? source.GymLocationId : entity.GymLocationId;
        entity.ClassFees = source.ClassFees > default(decimal) && source.ClassFees != entity.ClassFees ? source.ClassFees : entity.ClassFees;
        entity.StartTime = source.StartTime;
        entity.EndTime = source.EndTime;
        return entity;
    }
}
