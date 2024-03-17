using gms.data.Models.Base;

namespace gms.data.Models.Gym;
public class GymEntity : BaseEntity
{
    public string Name { get; set; }
    public int GeneralSettingId { get; set; }
    public virtual GymGeneralSettingEntity GeneralSetting { get; set; }
    public virtual ICollection<GymBranchEntity> GymBranches { get; set; }
}
