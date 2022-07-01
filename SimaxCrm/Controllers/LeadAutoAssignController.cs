using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SimaxCrm.Model.Entity;
using SimaxCrm.Model.Enum;
using SimaxCrm.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimaxCrm.Controllers
{
    [Authorize]
    public class LeadAutoAssignController : BaseController
    {
        private readonly ILeadAutoAssignService _leadAutoAssignService;
        private readonly ILeadSourceService _leadSourceService;
        private readonly ILeadAutoAssignSourceMappingService _leadAutoAssignSourceMappingService;
        private readonly UserManager<ApplicationUser> _userManager;

        public LeadAutoAssignController(ILeadAutoAssignService leadAutoAssignService,
            ILeadSourceService leadSourceService,
            UserManager<ApplicationUser> userManager,
            ILeadAutoAssignSourceMappingService leadAutoAssignSourceMappingService

            )
        {
            _leadAutoAssignService = leadAutoAssignService;
            _leadSourceService = leadSourceService;
            _userManager = userManager;
            _leadAutoAssignSourceMappingService = leadAutoAssignSourceMappingService;
        }

        // GET: ServiceType
        public IActionResult Index()
        {
            return View(_leadAutoAssignService.List());
        }

        // GET: ServiceType/Create
        public IActionResult Create()
        {
            ViewBag.LeadSourceId = new SelectList(_leadSourceService.List().Where(m => m.Status).ToList(), "Id", "Name");
            ViewBag.UserId = new SelectList(getAgentList(), "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(LeadAutoAssign obj)
        {
            if (ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(obj.LeadSources))
                {
                    ModelState.AddModelError("LeadSources", "Select Any Source");
                }
                else
                {
                    obj.CreatedDate = DateTime.Now;
                    _leadAutoAssignService.Create(obj);

                    foreach (var item in obj.LeadSources.Split(','))
                    {
                        var leadAutoAssignSourceMapping = new LeadAutoAssignSourceMapping()
                        {
                            Id = 0,
                            LeadAutoAssignId = obj.Id,
                            LeadSourceId = int.Parse(item),
                            CreatedDate = DateTime.Now
                        };
                        _leadAutoAssignSourceMappingService.Create(leadAutoAssignSourceMapping);
                    }

                    return RedirectToAction(nameof(Index));
                }
            }
            ViewBag.LeadSourceId = new SelectList(_leadSourceService.List().Where(m => m.Status).ToList(), "Id", "Name");
            ViewBag.UserId = new SelectList(getAgentList(), "Id", "Name");
            return View(obj);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var obj = _leadAutoAssignService.ById(id);
            if (obj == null)
            {
                return NotFound();
            }
            ViewBag.LeadSourceId = new SelectList(_leadSourceService.List().Where(m => m.Status).ToList(), "Id", "Name");
            ViewBag.UserId = new SelectList(getAgentList(), "Id", "Name");
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, LeadAutoAssign obj)
        {
            if (id != obj.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(obj.LeadSources))
                {
                    ModelState.AddModelError("LeadSources", "Select Any Source");
                }
                else
                {

                    obj.UpdatedDate = DateTime.Now;
                    _leadAutoAssignService.Update(obj);

                    var existingMapping = _leadAutoAssignSourceMappingService.ByLeadAutoAssignId(id);
                    foreach (var mapping in existingMapping)
                    {
                        _leadAutoAssignSourceMappingService.Delete(mapping.Id);
                    }

                    foreach (var item in obj.LeadSources.Split(','))
                    {
                        var leadAutoAssignSourceMapping = new LeadAutoAssignSourceMapping()
                        {
                            Id = 0,
                            LeadAutoAssignId = obj.Id,
                            LeadSourceId = int.Parse(item),
                            CreatedDate = DateTime.Now
                        };
                        _leadAutoAssignSourceMappingService.Create(leadAutoAssignSourceMapping);
                    }

                    return RedirectToAction(nameof(Index));
                }
            }
            ViewBag.LeadSourceId = new SelectList(_leadSourceService.List().Where(m => m.Status).ToList(), "Id", "Name");
            ViewBag.UserId = new SelectList(getAgentList(), "Id", "Name");
            return View(obj);
        }

        // GET: ServiceType/Delete/5
        public IActionResult Delete(int id)
        {
            var obj = _leadAutoAssignService.ById(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // POST: ServiceType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _leadAutoAssignService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private List<ApplicationUser> getAgentList()
        {
            var tid = base.getTidFromClaim();
            var users = _userManager.Users.Where(m => m.Tid == tid).Include(u => u.UserRoles).ThenInclude(ur => ur.Role).ToList();
            return users.Where(m => m.UserRoles.Any(m => m.Role.Name == UserType.Agent.ToString())).ToList();
        }
    }
}
