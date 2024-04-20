using gms.data.Models.Base;

namespace gms.data.Models.Class;

public class ClassLocationEntity : BaseEntity
{
    public required string Name { get; set; }

    // Navigation properties
    public virtual ICollection<ClassScheduleEntity> ClassSchedules { get; set; }
}
