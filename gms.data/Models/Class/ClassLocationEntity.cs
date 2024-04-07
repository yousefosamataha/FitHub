using gms.data.Models.Base;

namespace gms.data.Models.Class;

public class ClassLocationEntity : BaseEntity
{
    public string Name { get; set; }

    public virtual ICollection<ClassScheduleEntity> ClassSchedules { get; set; }
}
