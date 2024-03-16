using gms.data.Models.Base;

namespace gms.data.Models.Gym;
public class GymEntity : BaseEntity
{
	public string Name { get; set; }
	//public int? GeneralSettingId { get; set; }

	// TODO: Should Add General Setting Entity And Gym Branch 
	// Navigation properties
	//public virtual gymgeneralsetting generalsetting { get; set; }
	public virtual ICollection<GymBranchEntity> GymBranches { get; set; }
}
