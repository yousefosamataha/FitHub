using gms.common.Enums;
using gms.data.Models.Base;
using gms.data.Models.Identity;

namespace gms.data.Models.Gym;

public class GymMeasurementEntity : BaseEntity
{
    public int GymMemberUserId { get; set; }
    public GymResultMeasurementEnum ResultMeasurementId { get; set; }
	public decimal Result { get; set; }
    public DateTime ResultDate { get; set; }

    // Navigation properties
    public virtual GymUserEntity GymMemberUser { get; set; }
    public virtual ICollection<MeasurementImageEntity> MeasurementImages { get; set; }
}
 