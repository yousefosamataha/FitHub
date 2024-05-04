using gms.common.Enums;
using gms.data.Models.Base;

namespace gms.data.Models.Gym;

public class GymGroupEntity : BaseEntity
{
    public int BranchId { get; set; }
    public required string Name { get; set; }
    public byte[]? Image { get; set; }
    public ImageTypeEnum? ImageTypeId { get; set; }

    // Navigation properties
    public virtual GymBranchEntity GymBranch { get; set; }
    public virtual ICollection<GymMemberGroupEntity> GymMemberGroups { get; set; }
    public virtual ICollection<GymStaffGroupEntity> GymStaffGroups { get; set; }
}
