using gms.data.Models.Base;

namespace gms.data.Models.Gym;

public class MeasurementImageEntity : BaseEntity
{
	public byte[] Image { get; set; }
	public int GymMeasurementId { get; set; }

    // Navigation properties
    public GymMeasurementEntity GymMeasurement { get; set; }
}
