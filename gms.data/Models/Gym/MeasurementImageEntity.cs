using gms.data.Models.Base.Entities;

namespace gms.data.Models.Gym;

public class MeasurementImageEntity : BaseEntity
{
	public byte[] Image { get; set; }
	public int MeasurementId { get; set; }

	public GymMeasurementEntity GymMeasurement { get; set; }
}
