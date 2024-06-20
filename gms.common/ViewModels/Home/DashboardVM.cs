using gms.common.Models.ClassCat.ClassScheduleDay;
using gms.common.Models.GymCat.Branch;
using gms.common.Models.Identity.User;
using gms.common.Models.MembershipCat.MembershipPaymentHistory;

namespace gms.common.ViewModels.Home;

public class DashboardVM
{
	public GymUserDTO GymUserDTO { get; set; }
	public GymBranchDTO GymBranchDTO { get; set; }
	public List<ClassScheduleDayDTO> classScheduleDaysList { get; set; }
	public List<MembershipPaymentHistoryDTO> MembershipPaymentHistoryList { get; set; }
}
