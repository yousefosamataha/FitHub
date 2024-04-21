using gms.data.Models.Base;
using gms.data.Models.Gym;

namespace gms.data.Models.Class;

public class ClassLocationEntity : BaseEntity
{
    public int BranchId { get; set; }
    public required string Name { get; set; }

    // Navigation properties
    public virtual GymBranchEntity GymBranch { get; set; }
    public virtual ICollection<ClassScheduleEntity> ClassSchedules { get; set; }
}
