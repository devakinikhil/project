using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SimaxCrm.Model.Entity;
using SimaxCrm.Model.Enum;
using SimaxCrm.Model.ResponseModel;
using SimaxCrm.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimaxCrm.Controllers
{
    public class LeadController : BaseController
    {
        private readonly ILeadService _leadService;
        private readonly ILeadSourceService _leadSourceService;
        private readonly ILeadLanguageService _leadLanguageService;
        private readonly ILeadTagService _leadTagService;
        private readonly ILeadTagMappingService _leadTagMappingService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILeadAutoAssignLogService _leadAutoAssignLogService;
        private readonly IHelperService _helperService;

        public LeadController(
            ILeadService leadService,
            ILeadSourceService leadSourceService,
            ILeadLanguageService leadLanguageService,
            ILeadTagService leadTagService,
            ILeadTagMappingService leadTagMappingService,
            UserManager<ApplicationUser> userManager,
            IHelperService helperService,
            ILeadAutoAssignLogService leadAutoAssignLogService
            )
        {
            _helperService = helperService;
            _leadService = leadService;
            _leadSourceService = leadSourceService;
            _leadLanguageService = leadLanguageService;
            _leadTagService = leadTagService;
            _leadTagMappingService = leadTagMappingService;
            _userManager = userManager;
            _leadAutoAssignLogService = leadAutoAssignLogService;
        }

        // GET: ServiceType
        public IActionResult Index()
        {
            var leads = _leadService.List();
            return View(leads);
        }

        // GET: ServiceType/Create
        public IActionResult Create()
        {
            ViewBag.LeadSourceId = new SelectList(_leadSourceService.List().Where(m => m.Status).ToList(), "Id", "Name");
            ViewBag.LeadLanguageId = new SelectList(_leadLanguageService.List().Where(m => m.Status).ToList(), "Id", "Name");
            ViewBag.LeadTagId = new SelectList(_leadTagService.List().Where(m => m.Status).ToList(), "Id", "Name");
            ViewBag.UserId = new SelectList(getAgentList(), "Id", "Name");
            return View();
        }


        private void setDefaultData()
        {
            ViewBag.LeadSourceId = new SelectList(_leadSourceService.List().Where(m => m.Status).ToList(), "Id", "Name");
            ViewBag.LeadLanguageId = new SelectList(_leadLanguageService.List().Where(m => m.Status).ToList(), "Id", "Name");
            ViewBag.LeadTagId = new SelectList(_leadTagService.List().Where(m => m.Status).ToList(), "Id", "Name");
            ViewBag.UserId = new SelectList(getAgentList(), "Id", "Name");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Lead obj)
        {
            if (ModelState.IsValid)
            {
                bool isAutoAssign = false;

                if (_leadService.IsAny(m => m.PhoneNumber == obj.PhoneNumber))
                {
                    setDefaultData();
                    ModelState.AddModelError("PhoneNumber", "Phone number already exists");
                    return View(obj);
                }

                if (_leadService.IsAny(m => m.Email == obj.Email))
                {
                    setDefaultData();
                    ModelState.AddModelError("Email", "Email already exists");
                    return View(obj);
                }

                if (obj.UserId == "Auto")
                {
                    isAutoAssign = true;
                    var userId = _helperService.AssignAgentSourceAndRankingWise(obj.LeadSourceId);
                    if (string.IsNullOrEmpty(userId))
                    {
                        ModelState.AddModelError("UserId", "No user available for lead auto assign");
                        setDefaultData();
                        return View(obj);
                    }
                    obj.UserId = userId;
                }

                obj.CreatedDate = DateTime.Now;
                obj.AssignedDate = DateTime.Now;
                obj.LeadStatus = LeadStatusType.NewLead.ToString();
                _leadService.Create(obj);

                if (isAutoAssign)
                {
                    var leadAutoAssignLog = new LeadAutoAssignLog()
                    {
                        Id = 0,
                        LeadId = obj.Id,
                        LeadSourceId = obj.LeadSourceId,
                        UserId = obj.UserId,
                        CreatedDate = DateTime.Now
                    };
                    _leadAutoAssignLogService.Create(leadAutoAssignLog);
                }

                if (!string.IsNullOrEmpty(obj.LeadTags))
                {
                    foreach (var item in obj.LeadTags.Split(','))
                    {
                        var leadTagMapping = new LeadTagMapping()
                        {
                            Id = 0,
                            LeadId = obj.Id,
                            LeadTagId = int.Parse(item),
                            CreatedDate = DateTime.Now,
                            Status = true,
                        };
                        _leadTagMappingService.Create(leadTagMapping);
                    }
                }

                ViewBag.Result = "Lead Saved Successfully, Lead Id: " + obj.Id;
                setDefaultData();
                ModelState.Clear();
                return View(new Lead());
            }
            setDefaultData();
            return View(obj);
        }

        private List<ApplicationUser> getAgentList()
        {
            var tid = base.getTidFromClaim();
            var users = _userManager.Users.Where(m => m.Tid == tid).Include(u => u.UserRoles).ThenInclude(ur => ur.Role).ToList();
            return users.Where(m => m.UserRoles.Any(m => m.Role.Name == UserType.Agent.ToString())).ToList();
        }

        public IActionResult Edit(int id)
        {
            var obj = _leadService.ById(id);
            if (obj == null)
            {
                return NotFound();
            }

            ViewBag.LeadSourceId = new SelectList(_leadSourceService.List().Where(m => m.Status).ToList(), "Id", "Name");
            ViewBag.LeadLanguageId = new SelectList(_leadLanguageService.List().Where(m => m.Status).ToList(), "Id", "Name");
            ViewBag.LeadTagId = new SelectList(_leadTagService.List().Where(m => m.Status).ToList(), "Id", "Name");
            ViewBag.UserId = new SelectList(getAgentList(), "Id", "Name");

            return View(obj);
        }

        [HttpPost]
        public JsonResult Edit(int id, Lead obj)
        {
            var result = new BaseResponse<string>();
            if (ModelState.IsValid)
            {
                if (_leadService.IsAny(m => m.PhoneNumber == obj.PhoneNumber && m.Id != id))
                {
                    result.Success = false;
                    result.Response = "Phone number already exists";
                    return Json(result);
                }

                if (_leadService.IsAny(m => m.Email == obj.Email && m.Id != id))
                {
                    result.Success = false;
                    result.Response = "Email already exists";
                    return Json(result);
                }

                var existingLead = _leadService.ById(id);
                existingLead.Address = obj.Address;
                existingLead.City = obj.City;
                existingLead.Country = obj.Country;
                existingLead.Email = obj.Email;
                existingLead.LeadLanguageId = obj.LeadLanguageId;
                existingLead.LeadSourceId = obj.LeadSourceId;
                existingLead.Name = obj.Name;
                existingLead.PhoneNumber = obj.PhoneNumber;
                existingLead.PostalCode = obj.PostalCode;
                existingLead.State = obj.State;
                existingLead.UpdatedDate = DateTime.Now;
                existingLead.UserId = obj.UserId;
                _leadService.Update(existingLead);

                var existingLeadTagMapping = _leadTagMappingService.ByLeadId(id);
                foreach (var leadTagMapping in existingLeadTagMapping)
                {
                    _leadTagMappingService.Delete(leadTagMapping.Id);
                }

                if (!string.IsNullOrEmpty(obj.LeadTags))
                {
                    foreach (var item in obj.LeadTags.Split(','))
                    {
                        var leadTagMapping = new LeadTagMapping()
                        {
                            Id = 0,
                            LeadId = obj.Id,
                            LeadTagId = int.Parse(item),
                            CreatedDate = DateTime.Now,
                            Status = true,
                        };
                        _leadTagMappingService.Create(leadTagMapping);
                    }
                }

                result.Success = true;
                return Json(result);
            }
            result.Success = false;
            var errors = string.Join(",", ModelState.Values.SelectMany(v => v.Errors).ToList().Select(x => x.ErrorMessage).Distinct().ToList());
            result.Response = errors;
            return Json(result);
        }

        // POST: ServiceType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _leadService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool RecordExists(int id)
        {
            return _leadService.IsAny(e => e.Id == id);
        }
    }
}
