using gms.common.Models.GymCat.GymSpecialization;

namespace gms.common.ViewModels.Gym;

public class GymSpecializationVM
{
	public CreateGymSpecializationDTO CreateGymSpecialization { get; set; }
	public List<GymSpecializationDTO> GymSpecializationsList { get; set; }
}
