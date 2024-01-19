using gms.data.Models.Base;

namespace gms.data.Models;
public class UserEntity : BaseEntity
{
    public string Name { get; set; }

    public int Height { get; set; }

    public int Weight { get; set; }
}
