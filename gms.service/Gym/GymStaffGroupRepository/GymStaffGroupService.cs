using gms.common.Models.GymCat.GymStaffGroup;
using gms.data;
using gms.data.Mapper.Gym;
using gms.data.Models.Gym;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Gym.StaffGroupRepository;

public class GymStaffGroupService : BaseRepository<GymStaffGroupEntity>, IGymStaffGroupService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public GymStaffGroupService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<bool> CreateNewGymStaffGroupAsync(List<CreateGymStaffGroupDTO> gymStaffGroupsListDto)
    {
        List<GymStaffGroupEntity> createGymStaffGroupsList = gymStaffGroupsListDto.Select(sg => sg.ToEntity()).ToList();
        await AddRangeAsync(createGymStaffGroupsList);
        return true;
    }

    public async Task<bool> UpdateGymStaffGroupAsync(List<CreateGymStaffGroupDTO> updateGymStaffGroupsListDto, int staffId)
    {
        List<GymStaffGroupEntity> currentGymStaffGroupsList = _context.GymStaffGroups.Where(mg => mg.GymStaffUserId == staffId).ToList();
        _context.GymStaffGroups.RemoveRange(currentGymStaffGroupsList);
        await _context.SaveChangesAsync();
        List<GymStaffGroupEntity> newGymStaffGroupsList = updateGymStaffGroupsListDto.Select(mg => mg.ToEntity()).ToList();
        await AddRangeAsync(newGymStaffGroupsList);
        return true;
    }
}
