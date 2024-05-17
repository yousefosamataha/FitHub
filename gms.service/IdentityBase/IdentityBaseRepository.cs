using gms.data;

namespace gms.service.IdentityBase;

public class IdentityBaseRepository<T> where T : class
{
    private readonly ApplicationDbContext _context;

    public IdentityBaseRepository(ApplicationDbContext context)
    {
        _context = context;
    }
}
