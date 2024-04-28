using gms.common.Models.GymCat.GymGeneralSetting;
using gms.data.Models.Gym;

namespace gms.data.Mapper.Gym;

public static class GeneralSettingMapper
{
    public static GymGeneralSettingEntity ToEntity(this CreateGeneralSettingDTO source)
    {
        return new GymGeneralSettingEntity()
        {
            Weight = source.Weight,
            Height = source.Height,
            Chest = source.Chest,
            Waist = source.Waist,
            Thing = source.Thing,
            Arms = source.Arms,
            Fat = source.Fat,
            ReminderDays = source.ReminderDays,
            ReminderMessage = source.ReminderMessage,
            IsShared = source.IsShared,
            ReportHeader = source.ReportHeader,
            ReportFooter = source.ReportFooter,
        };
    }

    public static GeneralSettingDTO ToDTO(this GymGeneralSettingEntity source)
    {
        return new GeneralSettingDTO()
        {
            Id = source.Id,
            Weight = source.Weight,
            Height = source.Height,
            Chest = source.Chest,
            Waist = source.Waist,
            Thing = source.Thing,
            Arms = source.Arms,
            Fat = source.Fat,
            ReminderDays = source.ReminderDays,
            ReminderMessage = source.ReminderMessage,
            IsShared = source.IsShared,
            ReportHeader = source.ReportHeader,
            ReportFooter = source.ReportFooter,
        };
    }
}
