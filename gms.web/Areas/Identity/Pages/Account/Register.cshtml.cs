using gms.common.Models.GymCat.Branch;
using gms.common.Models.GymCat.Gym;
using gms.common.Models.Shared.Country;
using gms.common.Models.SubscriptionCat.SystemSubscription;
using gms.data.Models.Identity;
using gms.service.Gym.GymBranchRepository;
using gms.service.Gym.GymRepository;
using gms.service.GymUserRepository;
using gms.service.Shared.CountryRepository;
using gms.service.Subscription.SystemSubscriptionRepository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using gms.service.Gym.GymGeneralSettingsRepository;
using gms.common.Models.GymCat.GymGeneralSetting;
using gms.data.Models.Gym;

namespace gms.web.Areas.Identity.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<GymUserEntity> _signInManager;
        private readonly UserManager<GymUserEntity> _userManager;
        private readonly IUserStore<GymUserEntity> _userStore;
        private readonly IUserEmailStore<GymUserEntity> _emailStore;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly IGymService _gymService;
        private readonly ISystemSubscriptionService _systemSubscriptionService;
        private readonly IGymGeneralSettingService _gymGeneralSettingService;
        private readonly IGymBranchService _gymBranchService;
        private readonly ICountryService _countryService;
        private readonly IGymUserService _gymUserService;

        public RegisterModel(
            UserManager<GymUserEntity> userManager,
            IUserStore<GymUserEntity> userStore,
            SignInManager<GymUserEntity> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            IGymService gymService,
            ISystemSubscriptionService systemSubscriptionService,
            IGymBranchService gymBranchService,
            ICountryService countryService,
            IGymUserService gymUserService,
            IGymGeneralSettingService gymGeneralSettingService)
        {
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = GetEmailStore();
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _gymService = gymService;
            _systemSubscriptionService = systemSubscriptionService;
            _countryService = countryService;
            _gymBranchService = gymBranchService;
            _gymUserService = gymUserService;
            _gymGeneralSettingService = gymGeneralSettingService;
        }

        [BindProperty]
        public InputModel Input { get; set; }
        public string ReturnUrl { get; set; }
        public IList<AuthenticationScheme> ExternalLogins { get; set; }
        public List<CountryDTO> CountriesList { get; set; }
        public class InputModel
        {
            // [Required]
            // [EmailAddress]
            // [Display(Name = "Email")]
            public string Email { get; set; }

            // [Required]
            // [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            // [DataType(DataType.Password)]
            // [Display(Name = "Password")]
            public string Password { get; set; }

            // [DataType(DataType.Password)]
            // [Display(Name = "Confirm password")]
            // [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            public CreateGymDTO GymDTO { get; set; }
            public CreateSystemSubscriptionDTO SystemSubscriptionDTO { get; set; }
            public CreateBranchDTO GymBranchDTO { get; set; }
            public GymUserEntity GymUser { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            CountriesList = await _countryService.GetCountriesListAsync();
            // ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            // (1) Create Gym
            var CreatedGym = await _gymService.CreateGymAsync(Input.GymDTO);

			// (2) Create SystemSubscription
			Input.SystemSubscriptionDTO.GymId = CreatedGym.Id;
            var CreatedSystemSubscription = await _systemSubscriptionService.CreateSystemSubscriptionAsync(Input.SystemSubscriptionDTO);

            // (3) Create GeneralSetting
            var GeneralSettingEntity = new GymGeneralSettingEntity();
            var GeneralSettingDTO = new CreateGeneralSettingDTO()
            {
                Weight = GeneralSettingEntity.Weight,
                Height = GeneralSettingEntity.Height,
                Chest = GeneralSettingEntity.Chest,
                Waist = GeneralSettingEntity.Waist,
                Thing = GeneralSettingEntity.Thing,
                Arms = GeneralSettingEntity.Arms,
                Fat = GeneralSettingEntity.Fat,
                ReminderDays = GeneralSettingEntity.ReminderDays,
                ReminderMessage = GeneralSettingEntity.ReminderMessage,
                IsShared = true,
                ReportHeader = GeneralSettingEntity.ReportHeader,
                ReportFooter = GeneralSettingEntity.ReportFooter,
            };
            var CreatedGeneralSetting = await _gymGeneralSettingService.CreateGymGeneralSettingAsync(GeneralSettingDTO);

            // (4) Create Branch
            Input.GymBranchDTO.GymId = CreatedGym.Id;
            Input.GymBranchDTO.BranchName = "Main Branch";
            Input.GymBranchDTO.IsMainBranch = true;
            Input.GymBranchDTO.GeneralSettingId = CreatedGeneralSetting.Id;
            var CreatedBranch = await _gymBranchService.CreateBranchAsync(Input.GymBranchDTO);

            // (5) Create User
            var user = CreateUser();
            user.EmailConfirmed = true;
            user.BranchId = CreatedBranch.Id;
            await _userStore.SetUserNameAsync(user, Input.Email, CancellationToken.None);
            await _emailStore.SetEmailAsync(user, Input.Email, CancellationToken.None);
            var result = await _userManager.CreateAsync(user, Input.Password);
            GymUserEntity createdUser = await _gymUserService.GetGymUserByEmail(Input.Email);


			// (6)
			CreatedSystemSubscription.CreatedById = createdUser.Id;
			var updatedSystemSubscription = await _systemSubscriptionService.UpdateSystemSubscriptionAsync(CreatedSystemSubscription);
			CreatedGeneralSetting.CreatedById = createdUser.Id;
			var updatedGeneralSetting = await _gymGeneralSettingService.UpdateGymGeneralSettingAsync(CreatedGeneralSetting);
			CreatedBranch.CreatedById = createdUser.Id;
			var updatedBranch = await _gymBranchService.UpdateBranchAsync(CreatedBranch);

			return LocalRedirect(returnUrl);
        }

        private GymUserEntity CreateUser()
        {
            try
            {
                var user = Activator.CreateInstance<GymUserEntity>();
                user.FirstName = Input.GymUser.FirstName;
                user.LastName = Input.GymUser.LastName;
                user.GenderId = Input.GymUser.GenderId;
                user.BirthDate = Input.GymUser.BirthDate;
                user.Email = Input.GymUser.Email;
                return user;
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(GymUserEntity)}'. " +
                    $"Ensure that '{nameof(GymUserEntity)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        private IUserEmailStore<GymUserEntity> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<GymUserEntity>)_userStore;
        }
    }
}
