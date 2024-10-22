﻿using gms.common.Enums;
using gms.data.Models.Gym;
using gms.data.Models.Member;
using gms.data.Models.Membership;
using gms.data.Models.Nutrition;
using gms.data.Models.Staff;
using gms.data.Models.Workout;
using Microsoft.AspNetCore.Identity;

namespace gms.data.Models.Identity;
public class GymUserEntity : IdentityUser<int>
{
    public int BranchId { get; set; }
    public byte[]? Image { get; set; }
    public ImageTypeEnum? ImageTypeId { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public GenderEnum GenderId { get; set; }
    public DateOnly BirthDate { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public StatusEnum StatusId { get; set; }
    public GymUserTypeEnum? GymUserTypeId { get; set; }
    public bool IsDeleted { get; set; }

    // Navigation properties
    public virtual GymBranchEntity GymBranch { get; set; }
    public virtual ICollection<GymStaffSpecializationEntity> GymStaffSpecializations { get; set; }
    public virtual ICollection<GymMemberMembershipEntity> GymMemberMemberships { get; set; }
    public virtual ICollection<StaffClassEntity> StaffClasses { get; set; }
    public virtual ICollection<MemberClassEntity> MemberClasses { get; set; }
    public virtual ICollection<GymMemberGroupEntity> GymMemberGroups { get; set; }
    public virtual ICollection<GymStaffGroupEntity> GymStaffGroups { get; set; }
    public virtual ICollection<WorkoutPlanEntity> MemberWorkoutPlans { get; set; }
    public virtual ICollection<WorkoutPlanEntity> StaffWorkoutPlans { get; set; }
    public virtual ICollection<GymMeasurementEntity> GymMeasurements { get; set; }
    public virtual ICollection<NutritionPlanEntity> MemberNutritionPlans { get; set; }
    public virtual ICollection<NutritionPlanEntity> StaffNutritionPlans { get; set; }
    public virtual ICollection<GymNotificationEntity> GymNotificationSenderUsers { get; set; }
    public virtual ICollection<GymNotificationEntity> GymNotificationReceiverUsers { get; set; }
}
