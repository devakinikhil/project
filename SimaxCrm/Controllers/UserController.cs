using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimaxCrm.Model.Entity;
using SimaxCrm.Model.Enum;
using SimaxCrm.Model.RequestModel;
using System.Linq;
using System.Threading.Tasks;

namespace SimaxCrm.Controllers
{
    [Authorize]
    public class UserController : BaseController
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public UserController(
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        // GET: ServiceType
        public IActionResult Index()
        {
            //var users = _userManager.Users.ToList();
            var tid = base.getTidFromClaim();
            var users = _userManager.Users.Where(m => m.Tid == tid).Include(u => u.UserRoles).ThenInclude(ur => ur.Role).ToList();
            if (!User.IsInRole(UserType.Admin.ToString()))
            {
                users = users.Where(m => m.UserRoles.Any(m => m.Role.Name == UserType.Agent.ToString())).ToList();
            }
            return View(users);
        }

        // GET: ServiceType/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAsync(RegistrationModel obj)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { Name = obj.Name, UserName = obj.Email, Email = obj.Email, Tid = getTidFromClaim() };
                var result = await _userManager.CreateAsync(user, obj.Password);
                if (result.Succeeded)
                {
                    var currentUser = await _userManager.FindByNameAsync(user.UserName);

                    var role = await _roleManager.FindByNameAsync(obj.Role);
                    if (role == null)
                    {
                        role = new ApplicationRole { Name = obj.Role };
                        await _roleManager.CreateAsync(role);
                    }
                    var roleresult = await _userManager.AddToRoleAsync(currentUser, obj.Role);

                    return RedirectToAction(nameof(Index));
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(obj);
        }

        public async Task<IActionResult> Edit(string id)
        {
            var obj = _userManager.Users.Include(u => u.UserRoles).ThenInclude(ur => ur.Role)
                .Where(m => m.Id == id).FirstOrDefault();

            if (obj == null)
            {
                return NotFound();
            }
            var model = new RegistrationUpdateModel()
            {
                Email = obj.Email,
                Name = obj.Name,
                Id = obj.Id,
                Role = obj.UserRoles.FirstOrDefault()?.Role?.Name
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAsync(string id, RegistrationUpdateModel obj)
        {
            if (id != obj.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var exObj = _userManager.Users.Include(u => u.UserRoles).ThenInclude(ur => ur.Role)
                .Where(m => m.Id == id).FirstOrDefault();
                exObj.Email = obj.Email;
                exObj.Name = obj.Name;
                await _userManager.UpdateAsync(exObj);

                var role = await _roleManager.FindByNameAsync(obj.Role);
                if (role == null)
                {
                    role = new ApplicationRole { Name = obj.Role };
                    await _roleManager.CreateAsync(role);
                }
                if (exObj.UserRoles.FirstOrDefault() != null)
                {
                    await _userManager.RemoveFromRoleAsync(exObj, exObj.UserRoles.FirstOrDefault().Role.Name);
                }
                await _userManager.AddToRoleAsync(exObj, obj.Role);

                return RedirectToAction(nameof(Index));
            }
            return View(obj);
        }

        public async Task<IActionResult> Reset(string id)
        {
            var obj = await _userManager.FindByIdAsync(id);
            if (obj == null)
            {
                return NotFound();
            }
            var model = new RegistrationPasswordModel()
            {
                Id = id
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Reset(string id, RegistrationPasswordModel obj)
        {
            if (id != obj.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(id);
                var token = _userManager.GeneratePasswordResetTokenAsync(user).Result;
                await _userManager.ResetPasswordAsync(user, token, obj.Password);
                return RedirectToAction(nameof(Index));
            }
            return View(obj);
        }


        // GET: ServiceType/Delete/5
        public async Task<IActionResult> DeleteAsync(string id)
        {
            var obj = await _userManager.FindByIdAsync(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // POST: ServiceType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmedAsync(string id)
        {
            var obj = await _userManager.FindByIdAsync(id);
            await _userManager.DeleteAsync(obj);
            return RedirectToAction(nameof(Index));
        }
    }
}
