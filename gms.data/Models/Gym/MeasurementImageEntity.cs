using gms.common.Enums;
using gms.data.Models.Base;

namespace gms.data.Models.Gym;

public class MeasurementImageEntity : BaseEntity
{
	public int GymMeasurementId { get; set; }
	public byte[] Image { get; set; }
    public ImageTypeEnum ImageTypeId { get; set; }

    // Navigation properties
    public virtual GymMeasurementEntity GymMeasurement { get; set; }
}
