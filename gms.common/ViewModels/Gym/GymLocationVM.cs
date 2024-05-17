using gms.common.Models.GymCat.GymLocation;

namespace gms.common.ViewModels.Gym;

public class GymLocationVM
{
    public CreateGymLocationDTO CreateGymLocation { get; set; }
    public GymLocationDTO GymLocation { get; set; }
    public List<GymLocationDTO> GymLocationList { get; set; }
}
