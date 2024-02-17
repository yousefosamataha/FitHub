using gms.data;
using gms.data.Contracts;
using gms.data.Models;
using gms.services.Base;

namespace gms.service.GymGroup
{
	public class GymGroupService : BaseRepository<GymGroupEntity>, IGymGroupService
	{
        private readonly ApplicationDbContext _context;
        public GymGroupService(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
