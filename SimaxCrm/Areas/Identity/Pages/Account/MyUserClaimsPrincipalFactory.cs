using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using SimaxCrm.Model.Entity;
using SimaxCrm.Service.Interface;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SimaxCrm.Areas.Identity.Pages.Account
{
    public class MyUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<ApplicationUser>
    {
        private readonly ITeamSlugService _teamSlugService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        public MyUserClaimsPrincipalFactory(
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager,
            IOptions<IdentityOptions> optionsAccessor,
            IHttpContextAccessor httpContextAccessor,
            ITeamSlugService teamSlugService
            )
                : base(userManager, optionsAccessor)
        {
            _teamSlugService = teamSlugService;
            _httpContextAccessor = httpContextAccessor;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser user)
        {
            var objTeam = _teamSlugService.ById(user.Tid);
            var identity = await base.GenerateClaimsAsync(user);
            var roles = await _userManager.GetRolesAsync(user);
            identity.AddClaim(new Claim("DbName", objTeam.DbName));
            identity.AddClaim(new Claim("Tid", objTeam.Id.ToString()));
            identity.AddClaim(new Claim(ClaimTypes.Role, string.Join(',', roles)));
            return identity;
        }
    }

}
