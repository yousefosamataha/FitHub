using gms.data;
using gms.data.Models.Staff;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Staff.StaffClassRepository;
public class StaffClassService : BaseRepository<StaffClassEntity>, IStaffClassService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public StaffClassService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }
}
