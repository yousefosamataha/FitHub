using gms.common.Models.ClassCat.ClassScheduleDay;
using gms.common.Models.GymCat.Branch;
using gms.common.Models.Identity.User;

namespace gms.common.ViewModels.Home;

public class DashboardVM
{
	public GymUserDTO GymUserDTO { get; set; }
	public GymBranchDTO GymBranchDTO { get; set; }
	public List<ClassScheduleDayDTO> classScheduleDaysList { get; set; }
}
