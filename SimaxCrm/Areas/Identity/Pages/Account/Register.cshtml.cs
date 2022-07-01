using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SimaxCrm.Model.Entity;
using SimaxCrm.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimaxCrm.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public partial class RegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly ITeamSlugService _teamSlugService;
        private readonly IConfiguration _configuration;

        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<ApplicationRole> roleManager,
            ILogger<RegisterModel> logger,
            ITeamSlugService teamSlugService,
            IConfiguration configuration,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _teamSlugService = teamSlugService;
            _roleManager = roleManager;
            _configuration = configuration;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                if (_teamSlugService.IsAny(m => m.Name == Input.CompanyName))
                {
                    ModelState.AddModelError(string.Empty, "Company Name Already Exists");
                    return Page();
                }

                if (await _userManager.FindByEmailAsync(Input.Email) != null)
                {
                    ModelState.AddModelError(string.Empty, "Email Id Already Exists");
                    return Page();
                }

                var defaultDbName = _configuration["ConnectionStrings:DbName"];

                var objTeam = new TeamSlug
                {
                    CreatedDate = DateTime.Now,
                    Id = 0,
                    DbName = defaultDbName,
                    Name = Input.CompanyName,
                    Status = true,
                };

                _teamSlugService.Create(objTeam);

                var user = new ApplicationUser { Tid = objTeam.Id, Name = Input.CompanyName, UserName = Input.Email, Email = Input.Email };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var currentUser = await _userManager.FindByEmailAsync(user.Email);
                    var role = await _roleManager.FindByIdAsync(user.Id);
                    if (role == null)
                    {
                        role = new ApplicationRole { Name = "Admin" };
                        await _roleManager.CreateAsync(role);
                    }
                    var roleresult = await _userManager.AddToRoleAsync(currentUser, "Admin");

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return LocalRedirect("/Dashboard");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
