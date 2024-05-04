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
            CreatedById = source.CreatedById,
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

	public static GymGeneralSettingEntity ToUpdatedEntity(this GeneralSettingDTO source, GymGeneralSettingEntity entity)
	{
		entity.Weight = !string.IsNullOrWhiteSpace(source.Weight) && !string.Equals(source.Weight, entity.Weight, StringComparison.OrdinalIgnoreCase) ? source.Weight : entity.Weight;
		entity.Height = !string.IsNullOrWhiteSpace(source.Height) && !string.Equals(source.Height, entity.Height, StringComparison.OrdinalIgnoreCase) ? source.Height : entity.Height;
		entity.Chest = !string.IsNullOrWhiteSpace(source.Chest) && !string.Equals(source.Chest, entity.Chest, StringComparison.OrdinalIgnoreCase) ? source.Chest : entity.Chest;
		entity.Waist = !string.IsNullOrWhiteSpace(source.Waist) && !string.Equals(source.Waist, entity.Waist, StringComparison.OrdinalIgnoreCase) ? source.Waist : entity.Waist;
		entity.Thing = !string.IsNullOrWhiteSpace(source.Thing) && !string.Equals(source.Thing, entity.Thing, StringComparison.OrdinalIgnoreCase) ? source.Thing : entity.Thing;
		entity.Fat = !string.IsNullOrWhiteSpace(source.Fat) && !string.Equals(source.Fat, entity.Fat, StringComparison.OrdinalIgnoreCase) ? source.Fat : entity.Fat;
		entity.ReminderDays = source.ReminderDays > default(int) && source.ReminderDays != entity.ReminderDays ? source.ReminderDays : entity.ReminderDays;
		entity.ReminderMessage = !string.IsNullOrWhiteSpace(source.ReminderMessage) && !string.Equals(source.ReminderMessage, entity.ReminderMessage, StringComparison.OrdinalIgnoreCase) ? source.ReminderMessage : entity.ReminderMessage;
		entity.IsShared = source.IsShared;
		entity.ReportHeader = source.ReportHeader;
		entity.ReportFooter = source.ReportFooter;
        entity.CreatedById = source.CreatedById > default(int) && source.CreatedById != entity.CreatedById ? source.CreatedById : entity.CreatedById;

		return entity;
	}
}
