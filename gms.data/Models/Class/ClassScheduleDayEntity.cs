using gms.common.Enums;
using gms.data.Models.Base;

namespace gms.data.Models.Class;

public class ClassScheduleDayEntity : BaseEntity
{
	public int ClassId { get; set; }
	public WeekDayEnum WeekDayId { get; set; }

	// TODO: Add Migration
	// public virtual ClassScheduleEntity ClassSchedule { get; set; }
}
