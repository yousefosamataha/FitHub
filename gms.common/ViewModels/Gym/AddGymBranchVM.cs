using gms.common.Models.GymCat.Branch;
using gms.common.Models.Shared.Country;

namespace gms.common.ViewModels.Gym;

public class AddNewBranchVM
{
    public CreateBranchDTO CreateBranch { get; set; }

    public List<CountryDTO> CountriesList { get; set; }
}
