using gms.common.Enums;
using gms.common.Models.GymCat.Branch;
using gms.common.Models.GymCat.Gym;
using gms.common.Models.GymCat.GymGeneralSetting;
using gms.common.Models.Shared.Country;
using gms.common.Models.SubscriptionCat.SystemSubscription;
using gms.data.Models.Identity;
using gms.service.Background;
using gms.service.Gym.GymBranchRepository;
using gms.service.Gym.GymGeneralSettingsRepository;
using gms.service.Gym.GymRepository;
using gms.service.Identity.GymRolesRepository;
using gms.service.Identity.GymUserRepository;
using gms.service.Shared.CountryRepository;
using gms.service.Subscription.SystemSubscriptionRepository;
using Hangfire;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace gms.web.Areas.Identity.Pages.Account
{
	public class RegisterModel : PageModel
	{
		private readonly UserManager<GymUserEntity> _userManager;
		private readonly SignInManager<GymUserEntity> _signInManager;
		private readonly ILogger<RegisterModel> _logger;
		private readonly IUserStore<GymUserEntity> _userStore;
		private readonly IUserEmailStore<GymUserEntity> _emailStore;
		private readonly IEmailSender _emailSender;
		private readonly IGymService _gymService;
		private readonly ISystemSubscriptionService _systemSubscriptionService;
		private readonly IGymBranchService _gymBranchService;
		private readonly ICountryService _countryService;
		private readonly IGymUserService _gymUserService;
		private readonly IGymRolesService _gymRoleService;
		private readonly IGymGeneralSettingService _gymGeneralSettingService;
		private readonly IBackgroundJobClient _backgroundJobClient;

		public RegisterModel(
			UserManager<GymUserEntity> userManager,
			SignInManager<GymUserEntity> signInManager,
			ILogger<RegisterModel> logger,
			IUserStore<GymUserEntity> userStore,
			IEmailSender emailSender,
			IGymService gymService,
			ISystemSubscriptionService systemSubscriptionService,
			IGymBranchService gymBranchService,
			ICountryService countryService,
			IGymUserService gymUserService,
			IGymRolesService gymRolesService,
			IGymGeneralSettingService gymGeneralSettingService,
			IBackgroundJobClient backgroundJobClient)
		{
			_userManager = userManager;
			_signInManager = signInManager;
			_logger = logger;
			_userStore = userStore;
			_emailStore = GetEmailStore();
			_emailSender = emailSender;
			_gymService = gymService;
			_systemSubscriptionService = systemSubscriptionService;
			_countryService = countryService;
			_gymBranchService = gymBranchService;
			_gymUserService = gymUserService;
			_gymRoleService = gymRolesService;
			_gymGeneralSettingService = gymGeneralSettingService;
			_backgroundJobClient = backgroundJobClient;
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
			GymDTO CreatedGym = await _gymService.CreateGymAsync(Input.GymDTO);

			// (2) Create SystemSubscription
			Input.SystemSubscriptionDTO.GymId = CreatedGym.Id;
			SystemSubscriptionDTO CreatedSystemSubscription = await _systemSubscriptionService.CreateSystemSubscriptionAsync(Input.SystemSubscriptionDTO);


			// (3) Add Background Job To Deactivate SystemSubscription
			_backgroundJobClient.Schedule<SubscriptionDeactivationJob>
			(
				job => job.DeactivateSubscriptionAsync(CreatedSystemSubscription.Id),
				CreatedSystemSubscription.SubscriptionEndTime
			);


			// (4) Create GeneralSetting
			CreateGeneralSettingDTO GeneralSettingDTO = new();
			GeneralSettingDTO.IsShared = true;
			GeneralSettingDTO CreatedGeneralSetting = await _gymGeneralSettingService.CreateGymGeneralSettingAsync(GeneralSettingDTO);

			// (5) Create Branch
			Input.GymBranchDTO.GymId = CreatedGym.Id;
			Input.GymBranchDTO.BranchName = BranchStrings.MainBranch;
			Input.GymBranchDTO.IsMainBranch = true;
			Input.GymBranchDTO.GeneralSettingId = CreatedGeneralSetting.Id;
			GymBranchDTO CreatedBranch = await _gymBranchService.CreateBranchAsync(Input.GymBranchDTO);

			// (6) Create Branch Roles
			await _gymRoleService.CreateRolesForBranchAsync(CreatedBranch.Id);

			// (7) Create User
			GymUserEntity user = CreateUser();
			user.EmailConfirmed = true;
			user.BranchId = CreatedBranch.Id;
			user.GymUserTypeId = GymUserTypeEnum.Owner;
			user.StatusId = StatusEnum.Active;
			user.Image = new byte[0];
			user.ImageTypeId = null;
			await _userStore.SetUserNameAsync(user, Input.Email, CancellationToken.None);
			await _emailStore.SetEmailAsync(user, Input.Email, CancellationToken.None);
			IdentityResult result = await _userManager.CreateAsync(user, Input.Password);
			GymUserEntity createdUser = await _gymUserService.GetGymUserByEmail(Input.Email);

			List<string> rolesList = new();

			foreach (var role in Enum.GetValues(typeof(RolesEnum)))
			{
				rolesList.Add($"{CreatedBranch.Id}_{role}");
			}

			await _userManager.AddToRolesAsync(user, rolesList);

			// (8)
			//CreatedSystemSubscription.CreatedById = createdUser.Id;
			//var updatedSystemSubscription = await _systemSubscriptionService.UpdateSystemSubscriptionAsync(CreatedSystemSubscription);
			//CreatedGeneralSetting.CreatedById = createdUser.Id;
			//var updatedGeneralSetting = await _gymGeneralSettingService.UpdateGymGeneralSettingAsync(CreatedGeneralSetting);
			//CreatedBranch.CreatedById = createdUser.Id;
			//var updatedBranch = await _gymBranchService.UpdateBranchAsync(CreatedBranch);

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
