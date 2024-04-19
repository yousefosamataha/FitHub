using gms.data.Models.Base;
using gms.data.Models.Identity;

namespace gms.data.Models.Gym;

public class GymGroupEntity : BaseEntity
{
    public int GymId { get; set; }
    public required string Name { get; set; }
    public byte[]? Image { get; set; }
    public int CreatedById { get; set; }

    // Navigation properties
    public virtual GymEntity Gym { get; set; }
    public virtual GymUserEntity GymStaffUser { get; set; }
    public virtual ICollection<GymStaffGroupEntity> GymStaffGroups { get; set; }
    public virtual ICollection<GymMemberGroupEntity> GymMemberGroups { get; set; }
}
