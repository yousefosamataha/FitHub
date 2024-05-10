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
            GymLocation = source.GymLocation.ToDTO()
        };
    }

    public static UpdateClassDTO ToUpdateDTO(this ClassDTO source)
    {
        return new UpdateClassDTO()
        {
            BranchId = source.BranchId,
            ClassName = source.ClassName,
            GymLocationId = source.GymLocationId,
            ClassFees = source.ClassFees,
            StartTime = source.StartTime,
            EndTime = source.EndTime,
        };
    }

    //public static ActivityEntity ToUpdatedEntity(this UpdateActivityDTO source, ClassScheduleEntity entity)
    //{
    //    entity.Title = !string.IsNullOrWhiteSpace(source.Title) && !string.Equals(source.Title, entity.Title, StringComparison.OrdinalIgnoreCase) ? source.Title : entity.Title;
    //    entity.BranchId = source.BranchId > default(int) && source.BranchId != entity.BranchId ? source.BranchId : entity.BranchId;
    //    entity.ActivityCategoryId = source.ActivityCategoryId > default(int) && source.ActivityCategoryId != entity.ActivityCategoryId ? source.ActivityCategoryId : entity.ActivityCategoryId;
    //    return entity;
    //}
}
