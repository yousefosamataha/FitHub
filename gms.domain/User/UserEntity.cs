using gms.domain.Base;

namespace gms.domain.User;
public class UserEntity : BaseEntity
{
    public string Name { get; set; }

    public int Height { get; set; }

    public int Weight { get; set; }
}
