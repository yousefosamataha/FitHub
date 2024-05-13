using gms.common.Models.ClassCat.ClassScheduleDay;
using gms.data.Models.Class;
using gms.services.Base;

namespace gms.service.Class.ClassScheduleDayRepository;
public interface IClassScheduleDayService : IBaseRepository<ClassScheduleDayEntity>
{
    Task<bool> CreateNewClassScheduleDaysAsync(List<CreateClassScheduleDayDTO> classScheduleDaysListDto);
    Task<List<ClassScheduleDayDTO>> GetClassScheduleDaysListAsync(int classId);
    Task<bool> UpdateClassScheduleDaysAsync(List<CreateClassScheduleDayDTO> updateClassScheduleDaysListDto, int classId);
}
