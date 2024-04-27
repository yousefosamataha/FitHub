using gms.common.Models.GymCat.Branch;
using gms.common.Models.GymCat.Gym;
using gms.common.Models.Shared.Country;
using gms.common.Models.SubscriptionCat.SystemSubscription;
using gms.data.Models.Identity;
using gms.service.Gym.GymBranchRepository;
using gms.service.Gym.GymRepository;
using gms.service.TestUser;
using gms.service.Shared.CountryRepository;
using gms.service.Subscription.SystemSubscriptionRepository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
            IGymUserService gymUserService)
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
            var CreatedGym = await _gymService.CreateGymAsync(Input.GymDTO);
            Input.SystemSubscriptionDTO.GymId = CreatedGym.Id;
            var CreatedSystemSubscription = await _systemSubscriptionService.CreateSystemSubscriptionAsync(Input.SystemSubscriptionDTO);

            var user = CreateUser();
            user.EmailConfirmed = true;
            // user.BranchId = null;
            await _userStore.SetUserNameAsync(user, Input.Email, CancellationToken.None);
            await _emailStore.SetEmailAsync(user, Input.Email, CancellationToken.None);
            var result = await _userManager.CreateAsync(user, Input.Password);
            GymUserEntity createdUser = await _userManager.FindByEmailAsync(Input.Email);

            Input.GymBranchDTO.GymId = CreatedGym.Id;
            Input.GymBranchDTO.BranchName = "Main Branch";
            Input.GymBranchDTO.IsMainBranch = true;
            var CreatedBranch = await _gymBranchService.CreateBranchAsync(Input.GymBranchDTO, createdUser.Id);
            createdUser.BranchId = CreatedBranch.Id;
            var userDTO = await _gymUserService.UpdateGymUser(createdUser);


            // ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            //if (ModelState.IsValid)
            //{


            //if (result.Succeeded)
            //{
            //    _logger.LogInformation("User created a new account with password.");

            //    var userId = await _userManager.GetUserIdAsync(user);
            //    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            //    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            //    var callbackUrl = Url.Page(
            //        "/Account/ConfirmEmail",
            //        pageHandler: null,
            //        values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl },
            //        protocol: Request.Scheme);

            //    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
            //        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

            //    if (_userManager.Options.SignIn.RequireConfirmedAccount)
            //    {
            //        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
            //    }
            //    else
            //    {
            //        await _signInManager.SignInAsync(user, isPersistent: false);
            //        return LocalRedirect(returnUrl);
            //    }
            //}
            //foreach (var error in result.Errors)
            //{
            //    ModelState.AddModelError(string.Empty, error.Description);
            //}
            // }

            // If we got this far, something failed, redisplay form
            // return Page();
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
