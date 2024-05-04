using gms.common.Models.GymCat.GymGroup;
using gms.data;
using gms.data.Mapper.Gym;
using gms.data.Models.Gym;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Gym.GymGroupRepository;

public class GymGroupService : BaseRepository<GymGroupEntity>, IGymGroupService
{
    private readonly ApplicationDbContext _context;

    public GymGroupService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
    {
        _context = context;
    }

	public async Task<GymGroupDTO> AddGymGroupAsync(CreateGymGroupDTO entity)
	{
		GymGroupEntity newGroupEntity = entity.ToEntity();
		await AddAsync(newGroupEntity);
		return newGroupEntity.ToDTO();
	}

	public async Task<List<GymGroupDTO>> GetGymGroupsListAsync(int branchId)
	{
		List<GymGroupEntity> listOfMembership = await FindAllAsync(gg => gg.BranchId == branchId);
		return listOfMembership.Select(gg => gg.ToDTO()).ToList();
	}
}
