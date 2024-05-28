using gms.common.Models.ClassCat.Class;
using gms.data;
using gms.data.Mapper.Class;
using gms.data.Models.Class;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace gms.service.Class.ClassScheduleRepository;
public class ClassScheduleService : BaseRepository<ClassScheduleEntity>, IClassScheduleService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly ILogger<ClassScheduleService> _logger;
	public ClassScheduleService
    (
        ApplicationDbContext context, 
        IHttpContextAccessor httpContextAccessor,
        ILogger<ClassScheduleService> logger
    ) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
		_logger = logger;
	}

	public async Task<List<ClassDTO>> GetClassesListAsync()
    {
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(ClassScheduleService), nameof(GetClassesListAsync), DateTime.Now.ToString() });

			List<ClassScheduleEntity> listOfClasses = await FindAllAsync(c => c.BranchId == GetBranchId(), ["GymLocation"]);
			return listOfClasses.Select(c => c.ToDTO()).ToList();
		}
		
    }

    public async Task<ClassDTO> CreateNewClassAsync(CreateClassDTO createClassDto)
    {
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(ClassScheduleService), nameof(CreateNewClassAsync), DateTime.Now.ToString() });
			
			ClassScheduleEntity classEntity = createClassDto.ToEntity();
			classEntity.BranchId = GetBranchId();
			await AddAsync(classEntity);
			return classEntity.ToDTO();
		}
		
    }

    public async Task<ClassDTO> GetClassByIdAsync(int id)
    {
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(ClassScheduleService), nameof(GetClassByIdAsync), DateTime.Now.ToString() });
			
			ClassScheduleEntity? classEntity = await FindAsync(a => a.Id == id && a.BranchId == GetBranchId());
			return classEntity.ToDTO();
		}
		
    }

    public async Task<ClassDTO> UpdateClassAsync(UpdateClassDTO updateClassDto)
    {
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(ClassScheduleService), nameof(UpdateClassAsync), DateTime.Now.ToString() });

			ClassScheduleEntity curentClassEntity = await FindAsync(a => a.Id == updateClassDto.Id);
			ClassScheduleEntity updatedClassEntity = updateClassDto.ToUpdatedEntity(curentClassEntity);
			await UpdateAsync(updatedClassEntity);
			return updatedClassEntity.ToDTO();
		}
		
    }

    public async Task<bool> DeleteClassAsync(int classId)
    {
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(ClassScheduleService), nameof(DeleteClassAsync), DateTime.Now.ToString() });

			ClassScheduleEntity classEntity = await FindAsync(a => a.Id == classId && a.BranchId == GetBranchId());
			await DeleteAsync(classEntity);
			return true;
		}
		
    }
}
