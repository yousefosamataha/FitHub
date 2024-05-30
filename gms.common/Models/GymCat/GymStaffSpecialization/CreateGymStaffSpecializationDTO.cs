namespace gms.common.Models.GymCat.GymStaffSpecialization;

public record CreateGymStaffSpecializationDTO
{
	public int GymStaffId { get; init; }
	public int GymSpecializationId { get; init; }
}
