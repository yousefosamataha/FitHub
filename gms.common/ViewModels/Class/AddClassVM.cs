using gms.common.Models.ClassCat.Class;
using gms.common.Models.GymCat.GymLocation;

namespace gms.common.ViewModels.Class;

public class AddClassVM
{
    public CreateClassDTO Class { get; set; }
    public List<GymLocationDTO> GymLocations { get; set; }
}
