using gms.data.Models.Base;

namespace gms.data.Models.Gym;

public class MeasurementImageEntity : BaseEntity
{
	public byte[] Image { get; set; }

	// TODO: Add Relation Entities
	// public int MeasurementId { get; set; }
	// public GymMeasurement GymMeasurement { get; set; }
}
