using gms.common.Models.ClassCat.Class;
using gms.data.Models.Class;
using gms.services.Base;

namespace gms.service.Class.ClassScheduleRepository;
public interface IClassScheduleService : IBaseRepository<ClassScheduleEntity>
{
    Task<List<ClassDTO>> GetClassesListAsync();
    Task<ClassDTO> CreateNewClassAsync(CreateClassDTO createClassDto);
    Task<ClassDTO> GetClassAsync(int id);
    Task<ClassDTO> UpdateClassAsync(UpdateClassDTO updateClassDto);
    Task<bool> DeleteClassAsync(int classId);
}
