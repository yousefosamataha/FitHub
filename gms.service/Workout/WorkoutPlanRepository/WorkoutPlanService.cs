using gms.common.Enums;
using gms.common.Models.WorkoutCat.WorkoutPlan;
using gms.data;
using gms.data.Mapper.Workout;
using gms.data.Models.Workout;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace gms.service.Workout.WorkoutPlanRepository;

public class WorkoutPlanService : BaseRepository<WorkoutPlanEntity>, IWorkoutPlanService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly ILogger<WorkoutPlanService> _logger;
    public WorkoutPlanService
    (
        ApplicationDbContext context,
        IHttpContextAccessor httpContextAccessor,
        ILogger<WorkoutPlanService> logger
    ) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
        _logger = logger;
    }

    public async Task<List<WorkoutPlanDTO>> GetWorkoutPlanListAsync()
    {
        using (_logger.BeginScope(GetScopesInformation()))
        {
            _logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
                                  new object[] { nameof(WorkoutPlanService), nameof(GetWorkoutPlanListAsync), DateTime.Now.ToString() });

            List<WorkoutPlanDTO> result = (await FindAllAsync(wp => wp.BranchId == GetBranchId())).Select(wp => wp.ToDTO()).ToList();

            return result;
        }
    }

    public async Task<WorkoutPlanDTO> CreateWorkoutPlanAsync(CreateWorkoutPlanDTO newWorkoutPlan)
    {
        using (_logger.BeginScope(GetScopesInformation()))
        {
            _logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
                                  new object[] { nameof(WorkoutPlanService), nameof(CreateWorkoutPlanAsync), DateTime.Now.ToString() });

            WorkoutPlanEntity newWorkoutPlanEntity = newWorkoutPlan.ToEntity();
			newWorkoutPlanEntity.BranchId = GetBranchId();
			newWorkoutPlanEntity.AssignedByGymStaffUserId = GetUserId();
			newWorkoutPlanEntity.WorkoutPlanStatusId = StatusEnum.Active;

			await AddAsync(newWorkoutPlanEntity);

            return newWorkoutPlanEntity.ToDTO();
        }
    }

    public async Task<WorkoutPlanDTO> UpdateWorkoutPlanAsync(UpdateWorkoutPlanDTO updateWorkoutPlanDTO)
    {
        using (_logger.BeginScope(GetScopesInformation()))
        {
            _logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
                                  new object[] { nameof(WorkoutPlanService), nameof(UpdateWorkoutPlanAsync), DateTime.Now.ToString() });

            WorkoutPlanEntity oldWorkoutPlanEntity = await FindAsync(wp => wp.Id == updateWorkoutPlanDTO.Id && wp.BranchId == GetBranchId());

            oldWorkoutPlanEntity = updateWorkoutPlanDTO.ToUpdatedEntity(oldWorkoutPlanEntity);

            await UpdateAsync(oldWorkoutPlanEntity);

            return oldWorkoutPlanEntity.ToDTO();
        }
    }

    public async Task<bool> DeleteWorkoutPlanAsync(int workoutPlanId)
    {
        using (_logger.BeginScope(GetScopesInformation()))
        {
            _logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
                                  new object[] { nameof(WorkoutPlanService), nameof(DeleteWorkoutPlanAsync), DateTime.Now.ToString() });

            WorkoutPlanEntity workoutPlanEntity = await FindAsync(wp => wp.Id == workoutPlanId && wp.BranchId == GetBranchId());

            await DeleteAsync(workoutPlanEntity);

            return true;
        }
    }

    public async Task<WorkoutPlanDTO> GetWorkoutPlanByIdAsync(int workoutPlanId)
    {
        using (_logger.BeginScope(GetScopesInformation()))
        {
            _logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
                                  new object[] { nameof(WorkoutPlanService), nameof(GetWorkoutPlanByIdAsync), DateTime.Now.ToString() });

            WorkoutPlanEntity workoutPlanEntity = await FindAsync(wp => wp.Id == workoutPlanId && wp.BranchId == GetBranchId());

            return workoutPlanEntity.ToDTO();

        }
    }

    public async Task<List<WorkoutPlanDTO>> GetWorkoutPlanListForMemberByMemberIdAsync(int userId)
    {
        using (_logger.BeginScope(GetScopesInformation()))
        {
            _logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
                                  new object[] { nameof(WorkoutPlanService), nameof(GetWorkoutPlanListForMemberByMemberIdAsync), DateTime.Now.ToString() });

            List<WorkoutPlanDTO> result = (await FindAllAsync(wp => wp.GymMemberUserId == userId && wp.BranchId == GetBranchId())).Select(wp => wp.ToDTO()).ToList();

            return result;
        }
    }

    public async Task<List<WorkoutPlanDTO>> GetWorkoutPlanListForStaffByStaffIdAsync(int userId)
    {
        using (_logger.BeginScope(GetScopesInformation()))
        {
            _logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
                                  new object[] { nameof(WorkoutPlanService), nameof(GetWorkoutPlanListForStaffByStaffIdAsync), DateTime.Now.ToString() });

            List<WorkoutPlanDTO> result = (await FindAllAsync(wp => wp.AssignedByGymStaffUserId == userId && wp.BranchId == GetBranchId())).Select(wp => wp.ToDTO()).ToList();

            return result;
        }
    }
}
