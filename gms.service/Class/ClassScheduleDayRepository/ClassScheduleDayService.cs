using gms.common.Models.ClassCat.ClassScheduleDay;
using gms.data;
using gms.data.Mapper.Class;
using gms.data.Models.Class;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Class.ClassScheduleDayRepository;
public class ClassScheduleDayService : BaseRepository<ClassScheduleDayEntity>, IClassScheduleDayService
{
	private readonly ApplicationDbContext _context;
	private readonly IHttpContextAccessor _httpContextAccessor;

	public ClassScheduleDayService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
	}

	public async Task<bool> CreateNewClassScheduleDaysAsync(List<CreateClassScheduleDayDTO> classScheduleDaysListDto)
	{
		List<ClassScheduleDayEntity> createClassScheduleDay = classScheduleDaysListDto.Select(cs => cs.ToEntity()).ToList();
		await AddRangeAsync(createClassScheduleDay);
		return true;
	}

	public async Task<List<ClassScheduleDayDTO>> GetClassScheduleDaysListAsync(int classId)
	{
		List<ClassScheduleDayEntity> classScheduleDaysList = await FindAllAsync(csd => csd.ClassScheduleId == classId);
		return classScheduleDaysList.Select(ma => ma.ToDTO()).ToList();
	}

	public async Task<List<ClassScheduleDayDTO>> GetClassScheduleDaysListAsync()
	{
		List<ClassScheduleDayEntity> classScheduleDaysList = await FindAllAsync(csd => csd.ClassSchedule.BranchId == GetBranchId(), ["ClassSchedule"]);
		return classScheduleDaysList.Select(ma => ma.ToDTO()).ToList();
	}

	public async Task<bool> UpdateClassScheduleDaysAsync(List<CreateClassScheduleDayDTO> updateClassScheduleDaysListDto, int classId)
	{
		List<ClassScheduleDayEntity> currentClassScheduleDaysList = await FindAllAsync(csd => csd.ClassScheduleId == classId);
		_context.ClassScheduleDays.RemoveRange(currentClassScheduleDaysList);
		await _context.SaveChangesAsync();
		List<ClassScheduleDayEntity> newClassScheduleDaysList = updateClassScheduleDaysListDto.Select(ma => ma.ToEntity()).ToList();
		await AddRangeAsync(newClassScheduleDaysList);
		return true;
	}
}
