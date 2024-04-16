using gms.data.Models.Base;

namespace gms.data.Models.Gym;

public class GymGroupEntity : BaseEntity
{
    public required string Name { get; set; }

    public byte[] Image { get; set; }

    public int GymId { get; set; }

    public virtual GymEntity Gym { get; set; }
}
