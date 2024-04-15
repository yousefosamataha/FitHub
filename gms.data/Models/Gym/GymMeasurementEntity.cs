using gms.common.Enums;
using gms.data.Models.Base;

namespace gms.data.Models.Gym;

public class GymMeasurementEntity : BaseEntity
{
	public GymResultMeasurementEnum ResultMeasurementId { get; set; }
	public decimal Result { get; set; }

	public virtual ICollection<MeasurementImageEntity> MeasurementImages { get; set; }

	// TODO: Add Relation Entities
	// public int MemberId { get; set; }
	// public int CreatedById { get; set; }
}
 