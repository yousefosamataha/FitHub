using gms.common.Models.MembershipCat;
using gms.data.Models.Membership;

namespace gms.data.Mapper.Membership;

public static class MembershipMapper
{
	public static GymMembershipPlanEntity ToEntity(this CreateMembershipDTO source)
	{
		return new GymMembershipPlanEntity()
		{
			BranchId = source.BranchId,
			MembershipName = source.MembershipName,
			MembershipDuration = source.MembershipDuration,
			MembershipDurationTypeId = source.MembershipDurationTypeId,
			MembershipAmount = source.MembershipAmount,
			MembershipStatusId = source.MembershipStatusId,
			SignupFee = source.SignupFee,
			MembershipDescription = source.MembershipDescription,
			ClassIsLimit = source.ClassIsLimit,
			ClassLimitDays = source.ClassLimitDays,
			ClassLimitationId = source.ClassLimitationId,
			CreatedById = source.CreatedById,
		};
	}

	public static MembershipDTO ToDTO(this GymMembershipPlanEntity source)
	{
		return new MembershipDTO()
		{
			Id = source.Id,
			BranchId = source.BranchId,
			MembershipName = source.MembershipName,
			MembershipDuration = source.MembershipDuration,
			MembershipDurationTypeId = source.MembershipDurationTypeId,
			MembershipAmount = source.MembershipAmount,
			MembershipStatusId = source.MembershipStatusId,
			SignupFee = source.SignupFee,
			MembershipDescription = source.MembershipDescription,
			ClassIsLimit = source.ClassIsLimit,
			ClassLimitDays = source.ClassLimitDays,
			ClassLimitationId = source.ClassLimitationId,
			CreatedById = source.CreatedById,
            CreatedAt = source.CreatedAt
		};
	}

	public static GymMembershipPlanEntity ToUpdatedEntity(this MembershipDTO source, GymMembershipPlanEntity entity)
	{
		entity.BranchId = source.BranchId > default(int) && source.BranchId != entity.BranchId ? source.BranchId : entity.BranchId;
		entity.MembershipName = !string.IsNullOrWhiteSpace(source.MembershipName) && !string.Equals(source.MembershipName, entity.MembershipName, StringComparison.OrdinalIgnoreCase) ? source.MembershipName : entity.MembershipName;
		entity.MembershipDuration = source.MembershipDuration > default(int) && source.MembershipDuration != entity.MembershipDuration ? source.MembershipDuration : entity.MembershipDuration;
		entity.MembershipDurationTypeId = source.MembershipDurationTypeId;
		entity.MembershipAmount = source.MembershipAmount > default(decimal) && source.MembershipAmount != entity.MembershipAmount ? source.MembershipAmount : entity.MembershipAmount;
		entity.MembershipStatusId = source.MembershipStatusId;
		entity.SignupFee = source.SignupFee > default(decimal) && source.SignupFee != entity.SignupFee ? source.SignupFee : entity.SignupFee;
		entity.MembershipDescription = !string.IsNullOrWhiteSpace(source.MembershipDescription) && !string.Equals(source.MembershipDescription, entity.MembershipDescription, StringComparison.OrdinalIgnoreCase) ? source.MembershipDescription : entity.MembershipDescription;
		entity.ClassIsLimit = source.ClassIsLimit;
		entity.ClassLimitDays = source.ClassLimitDays > default(int) && source.ClassLimitDays != entity.ClassLimitDays ? source.ClassLimitDays : entity.ClassLimitDays;
		entity.ClassLimitationId = source.ClassLimitationId;
		entity.CreatedById = source.CreatedById > default(int) && source.CreatedById != entity.CreatedById ? source.CreatedById : entity.CreatedById;

		return entity;
	}
}
