using gms.common.Models.GymCat.Branch;
using gms.common.Models.GymCat.Gym;
using gms.common.Models.Shared.Country;

namespace gms.common.ViewModels;

public class RegisterNewAccountVM
{
    public CreateGymDTO GymDTO { get; set; }
    public CreateBranchDTO GymBranchDTO { get; set; }
    public List<CountryDTO> CountriesList { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int? GenderId { get; set; }
    public string? Birthdate { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public string? ConfirmPassword { get; set; }
    public int? SubscriptionTypeId { get; set; }
    public int? PlanId { get; set; }

   // public GymUserEntity GymUserDTO { get; set; }
}
