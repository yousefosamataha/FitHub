using gms.common.Models.WorkoutCat.WorkoutPlan;
using gms.data.Models.Workout;
using gms.services.Base;

namespace gms.service.Workout.WorkoutPlanRepository;
public interface IWorkoutPlanService : IBaseRepository<WorkoutPlanEntity>
{
    Task<List<WorkoutPlanDTO>> GetWorkoutPlanListAsync();

    Task<WorkoutPlanDTO> CreateWorkoutPlanAsync(CreateWorkoutPlanDTO newWorkoutPlan);

    Task<WorkoutPlanDTO> UpdateWorkoutPlanAsync(UpdateWorkoutPlanDTO updateWorkoutPlanDTO);

    Task<bool> DeleteWorkoutPlanAsync(int workoutPlanId);

    Task<WorkoutPlanDTO> GetWorkoutPlanByIdAsync(int workoutPlanId);

    Task<List<WorkoutPlanDTO>> GetWorkoutPlanListForMemberByMemberIdAsync(int userId);

    Task<List<WorkoutPlanDTO>> GetWorkoutPlanListForStaffByStaffIdAsync(int userId);
}
