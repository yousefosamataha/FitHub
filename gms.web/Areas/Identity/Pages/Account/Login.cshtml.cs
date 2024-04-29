// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using gms.common.Models.Identity;
using gms.data.Mapper.Identity;
using gms.data.Models.Identity;
using gms.service.TestUser;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
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

                        List<Claim> claims = GetCustomClaims(user.ToClaimsDTO());

                        ClaimsPrincipal userPrincipal = await _signInManager.CreateUserPrincipalAsync(user);

                        ((ClaimsIdentity)userPrincipal.Identity).AddClaims(claims);

                        await _userManager.UpdateSecurityStampAsync(user);

                        await HttpContext.SignInAsync(IdentityConstants.ApplicationScheme, userPrincipal,
                            new AuthenticationProperties
                            {
                                IsPersistent = Input.RememberMe
                            }
                        );

                        _logger.LogInformation("User logged in.");
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

        private List<Claim> GetCustomClaims(GymUserClaimsDto user)
        {
            List<Claim> claims = new();

            PropertyInfo[] properties = user.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                object value = property.GetValue(user);
                if (value is not null)
                    claims.Add(new Claim(property.Name, value.ToString()));
            }

            return claims;
        }
    }
}
