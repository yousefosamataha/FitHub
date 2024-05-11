using gms.common.Models.ClassCat.Class;
using gms.data;
using gms.data.Mapper.Class;
using gms.data.Models.Class;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Class.ClassScheduleRepository;
public class ClassScheduleService : BaseRepository<ClassScheduleEntity>, IClassScheduleService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public ClassScheduleService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<List<ClassDTO>> GetClassesListAsync()
    {
        List<ClassScheduleEntity> listOfClasses = await FindAllAsync(c => c.BranchId == GetBranchId(), ["GymLocation"]);
        return listOfClasses.Select(c => c.ToDTO()).ToList();
    }

    public async Task<ClassDTO> CreateNewClassAsync(CreateClassDTO createClassDto)
    {
        ClassScheduleEntity classEntity = createClassDto.ToEntity();
        classEntity.BranchId = GetBranchId();
        await AddAsync(classEntity);
        return classEntity.ToDTO();
    }

    public async Task<ClassDTO> GetClassAsync(int id)
    {
        var classEntity = await FindAsync(a => a.Id == id && a.BranchId == GetBranchId());
        return classEntity.ToDTO();
    }

    public async Task<ClassDTO> UpdateClassAsync(UpdateClassDTO updateClassDto)
    {
        ClassScheduleEntity curentClassEntity = await FindAsync(a => a.Id == updateClassDto.Id);
        ClassScheduleEntity updatedClassEntity = updateClassDto.ToUpdatedEntity(curentClassEntity);
        await UpdateAsync(updatedClassEntity);
        return updatedClassEntity.ToDTO();
    }

    public async Task<bool> DeleteClassAsync(int classId)
    {
        ClassScheduleEntity classEntity = await FindAsync(a => a.Id == classId && a.BranchId == GetBranchId());
        await DeleteAsync(classEntity);
        return true;
    }
}
