using gms.data.Models.Base;
using gms.data.Models.Identity;

namespace gms.data.Models.Gym;
public class GymEntity : BaseEntity
{
    public string Name { get; set; }
    public int GeneralSettingId { get; set; }
    public virtual GymGeneralSettingEntity GeneralSetting { get; set; }
    public virtual ICollection<GymBranchEntity> GymBranches { get; set; }
    public virtual ICollection<GymUserEntity> GymUsers { get; set; }
}
