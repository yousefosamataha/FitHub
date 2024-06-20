// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using gms.common.Enums;
using gms.common.Models.Identity.User;
using gms.data.Mapper.Identity;
using gms.data.Models.Identity;
using gms.service.Identity.GymUserRepository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
namespace gms.web.Areas.Identity.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<GymUserEntity> _signInManager;
        private readonly UserManager<GymUserEntity> _userManager;
        private readonly ILogger<LoginModel> _logger;
        private readonly IGymUserService _gymUserService;

        public LoginModel(SignInManager<GymUserEntity> signInManager, ILogger<LoginModel> logger, UserManager<GymUserEntity> userManager, IGymUserService gymUserService)
        {
            _signInManager = signInManager;
            _logger = logger;
            _userManager = userManager;
            _gymUserService = gymUserService;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl ??= Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    GymUserEntity user = await _gymUserService.GetGymUserByEmail(Input.Email);

                    if (user is not null)
                    {
                        if (user.GymBranch.Gym.SystemSubscriptions.OrderBy(ss => ss.SubscriptionStartTime).FirstOrDefault().SubscriptionStatusId == StatusEnum.InActive) {
                        
                            if(user.GymUserTypeId == GymUserTypeEnum.Owner)
                            {                        
                                return RedirectToAction( "UpgradePlan", "Gym");
                            }
                            else
                            {

                            }
                        }
                        else
                        {
							await GetCustomClaims(user);

							await _signInManager.RefreshSignInAsync(user);

							_logger.LogInformation("User logged in.");

                            if (user.GymUserTypeId == GymUserTypeEnum.Owner)
                            {
                                return RedirectToAction("SelectGymBranch", "Gym");
                            }
                        }

                        return LocalRedirect(returnUrl);
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        private async Task<List<Claim>> GetCustomClaims(GymUserEntity user)
        {
            try
            {
                List<Claim> claims = new();

                GymUserClaimsDto claimsObject = user.ToClaimsDTO();

                claims.Add(new Claim("UserId", claimsObject.UserId.ToString()));
                claims.Add(new Claim("GymId", claimsObject.GymId.ToString()));
                claims.Add(new Claim("BranchId", claimsObject.BranchId.ToString()));
                claims.Add(new Claim("FirstName", claimsObject.FirstName.ToString()));
                claims.Add(new Claim("LastName", claimsObject.LastName.ToString()));
                claims.Add(new Claim("GenderId", claimsObject.GenderId.ToString()));
                claims.Add(new Claim("Email", claimsObject.Email.ToString()));
                claims.Add(new Claim("UserStatusId", claimsObject.UserStatusId.ToString()));
                claims.Add(new Claim("GymUserTypeId", claimsObject.GymUserTypeId.ToString()));

                ClaimsIdentity identity = new(claims);

                ClaimsPrincipal userPrincipal = new(identity);

                var result = await _userManager.AddClaimsAsync(user, claims);

                return claims;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
