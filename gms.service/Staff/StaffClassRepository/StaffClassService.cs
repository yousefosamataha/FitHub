using gms.data;
using gms.data.Models.Staff;
using gms.services.Base;

namespace gms.service.Staff.StaffClassRepository;
public class StaffClassService : BaseRepository<StaffClassEntity>, IStaffClassService
{
    private readonly ApplicationDbContext _context;
    public StaffClassService(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
