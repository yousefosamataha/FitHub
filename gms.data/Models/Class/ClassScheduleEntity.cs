using gms.data.Models.Base;

namespace gms.data.Models.Class;

public class ClassScheduleEntity : BaseEntity
{
	public string ClassName { get; set; }
	public int ClassLocationId { get; set; }
	public decimal ClassFees { get; set; }
	public TimeOnly StartTime { get; set; }
	public TimeOnly EndTime { get; set; }

	// TODO: Add Migration
	// public virtual ClassLocationEntity ClassLocation { get; set; }
	// public virtual ICollection<ClassScheduleDayEntity> ClassScheduleDays { get; set; }

	// TODO: Add Relation Entities
	// public ICollection<GymStaffClass> GymStaffClasses { get; set; }
	// public int CreatedById { get; set; }
}
