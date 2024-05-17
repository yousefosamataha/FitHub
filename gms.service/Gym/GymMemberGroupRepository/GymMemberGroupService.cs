using gms.common.Models.GymCat.GymMemberGroup;
using gms.data;
using gms.data.Mapper.Gym;
using gms.data.Models.Gym;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Gym.GymMemberGroupRepository;
public class GymMemberGroupService : BaseRepository<GymMemberGroupEntity>, IGymMemberGroupService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public GymMemberGroupService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<bool> CreateNewGymMemberGroupAsync(List<CreateGymMemberGroupDTO> gymMemberGroupsListDto)
    {
        List<GymMemberGroupEntity> createGymMemberGroupsList = gymMemberGroupsListDto.Select(mg => mg.ToEntity()).ToList();
        await AddRangeAsync(createGymMemberGroupsList);
        return true;
    }


    public async Task<List<GymMemberGroupDTO>> GetGymMemberGroupsListAsync(int memberId)
    {
        List<GymMemberGroupEntity> gymMemberGroupsList = await FindAllAsync(mg => mg.GymMemberUserId == memberId);
        return gymMemberGroupsList.Select(mg => mg.ToDTO()).ToList();
    }

    public async Task<bool> UpdateGymMemberGroupAsync(List<CreateGymMemberGroupDTO> updateGymMemberGroupsListDto, int memberId)
    {
        List<GymMemberGroupEntity> currentGymMemberGroupsList = await FindAllAsync(mg => mg.GymMemberUserId == memberId);
        _context.GymMemberGroups.RemoveRange(currentGymMemberGroupsList);
        await _context.SaveChangesAsync();
        List<GymMemberGroupEntity> newGymMemberGroupsList = updateGymMemberGroupsListDto.Select(mg => mg.ToEntity()).ToList();
        await AddRangeAsync(newGymMemberGroupsList);
        return true;
    }
}
