namespace gms.common.Models.GymCat.GymStaffSpecialization;

public record GymStaffSpecializationDTO
{
	public int Id { get; init; }
	public int GymStaffId { get; init; }
	public int GymSpecializationId { get; init; }
}
