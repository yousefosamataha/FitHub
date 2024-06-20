using gms.common.Enums;
using gms.common.Models.WorkoutCat.WorkoutPlan;
using gms.data.Mapper.Gym;
using gms.data.Mapper.Identity;
using gms.data.Models.Workout;

namespace gms.data.Mapper.Workout;

public static class WorkoutPlanMApper
{
    public static WorkoutPlanEntity ToEntity(this CreateWorkoutPlanDTO source)
    {
        return new WorkoutPlanEntity()
        {
            BranchId = source.BranchId,
            AssignedByGymStaffUserId = source.AssignedByGymStaffUserId,
            GymMemberUserId = source.GymMemberUserId,
            MemberLevelId = source.MemberLevelId,
            WorkoutPlanStatusId = source.WorkoutPlanStatusId,
            StartDate = source.StartDate,
            EndDate = source.EndDate,
            Description = source.Description
        };
    }

    public static WorkoutPlanDTO ToDTO(this WorkoutPlanEntity source)
    {
        return new WorkoutPlanDTO()
        {
            Id = source.Id,
            BranchId = source.BranchId,
            AssignedByGymStaffUserId = source.AssignedByGymStaffUserId,
            GymMemberUserId = source.GymMemberUserId,
            MemberLevelId = source.MemberLevelId,
            WorkoutPlanStatusId = source.WorkoutPlanStatusId,
            StartDate = source.StartDate,
            EndDate = source.EndDate,
            Description = source.Description,
            GymBranch = source.GymBranch?.ToDTO(),
            GymStaffUser = source.GymStaffUser?.ToDTO(),
            GymMemberUser = source.GymMemberUser?.ToDTO(),
            WorkoutPlanActivities = source.WorkoutPlanActivities?.Select(wpa => wpa.ToDTO()).ToList()
        };
    }

    public static WorkoutPlanEntity ToUpdatedEntity(this UpdateWorkoutPlanDTO source, WorkoutPlanEntity entity)
    {
        entity.WorkoutPlanStatusId = Enum.IsDefined(typeof(StatusEnum), source.WorkoutPlanStatusId) &&
                                     entity.WorkoutPlanStatusId != source.WorkoutPlanStatusId ?
                                     source.WorkoutPlanStatusId : entity.WorkoutPlanStatusId;

        entity.MemberLevelId = Enum.IsDefined(typeof(MemberLevelEnum), source.MemberLevelId) &&
                                     entity.MemberLevelId != source.MemberLevelId ?
                                     source.MemberLevelId : entity.MemberLevelId;

        entity.Description = !string.IsNullOrWhiteSpace(source.Description) &&
                             !string.Equals(source.Description, entity.Description, StringComparison.OrdinalIgnoreCase) ?
                             source.Description : entity.Description;

        entity.StartDate = source.StartDate;

        entity.EndDate = source.EndDate;



        return entity;
    }
}
