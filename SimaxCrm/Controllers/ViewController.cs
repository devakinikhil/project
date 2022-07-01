using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SimaxCrm.Model.Entity;
using SimaxCrm.Model.Enum;
using SimaxCrm.Model.RequestModel;
using SimaxCrm.Model.ResponseModel;
using SimaxCrm.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimaxCrm.Controllers
{
    public class ViewController : BaseController
    {
        private readonly ILeadService _leadService;
        private readonly ILeadSourceService _leadSourceService;
        private readonly ILeadLanguageService _leadLanguageService;
        private readonly ILeadTagService _leadTagService;
        private readonly ILeadTagMappingService _leadTagMappingService;
        private readonly UserManager<ApplicationUser> _userManager;

        public ViewController(
            ILeadService leadService,
            ILeadSourceService leadSourceService,
            ILeadLanguageService leadLanguageService,
            ILeadTagService leadTagService,
            ILeadTagMappingService leadTagMappingService,
            UserManager<ApplicationUser> userManager

            )
        {
            _leadService = leadService;
            _leadSourceService = leadSourceService;
            _leadLanguageService = leadLanguageService;
            _leadTagService = leadTagService;
            _leadTagMappingService = leadTagMappingService;
            _userManager = userManager;
        }

        public IActionResult Leads(string id)
        {
            var model = new LeadsViewFilterModel()
            {
                LeadStatus = id,
                CurrentLeadStatus = id,
                UserId = ""
            };
            List<Lead> leads = getLeadsByLeadStatus(model);
            ViewBag.Title = id;
            ViewBag.AllLead = model;
            ViewBag.UserId = new SelectList(getAgentList(), "Id", "Name");
            return View(leads);
        }

        private List<Lead> getLeadsByLeadStatus(LeadsViewFilterModel leadsViewFilterModel)
        {
            Guid? uid = null;
            if (User.IsInRole(UserType.Agent.ToString()))
            {
                uid = base.getUidFromClaim();
            }
            List<Lead> leads = null;

            if (!string.IsNullOrEmpty(leadsViewFilterModel.UserId))
            {
                uid = Guid.Parse(leadsViewFilterModel.UserId);
            }

            if (leadsViewFilterModel.LeadStatus == "MissedFollowUp")
            {
                leads = _leadService.ByLeadStatusAndUserId("FollowUp", uid, leadsViewFilterModel.StartDate, leadsViewFilterModel.EndDate);
                leads = leads.Where(m => m.AlertDate.Value.Date < DateTime.Now.Date).ToList();
            }
            else if (leadsViewFilterModel.LeadStatus == "FollowUp")
            {
                leads = _leadService.ByLeadStatusAndUserId(leadsViewFilterModel.LeadStatus, uid, leadsViewFilterModel.StartDate, leadsViewFilterModel.EndDate);
                leads = leads.Where(m => m.AlertDate.Value.Date == DateTime.Now.Date).ToList();
            }
            else if (leadsViewFilterModel.LeadStatus == "AllLead")
                leads = _leadService.ByUserId(uid, leadsViewFilterModel.StartDate, leadsViewFilterModel.EndDate);
            else
                leads = _leadService.ByLeadStatusAndUserId(leadsViewFilterModel.LeadStatus, uid, leadsViewFilterModel.StartDate, leadsViewFilterModel.EndDate);

            return leads.OrderByDescending(m => m.Id).ToList();
        }

        [HttpPost]
        public IActionResult Leads(LeadsViewFilterModel model)
        {
            List<Lead> leads = getLeadsByLeadStatus(model);
            ViewBag.Title = model.CurrentLeadStatus;
            ViewBag.AllLead = model;
            ViewBag.UserId = new SelectList(getAgentList(), "Id", "Name");
            return View(leads);
        }

        public IActionResult Lead(int id)
        {
            int leadId = id;
            var lead = _leadService.ById(leadId);

            ViewBag.LeadSourceId = new SelectList(_leadSourceService.List().Where(m => m.Status).ToList(), "Id", "Name");
            ViewBag.LeadLanguageId = new SelectList(_leadLanguageService.List().Where(m => m.Status).ToList(), "Id", "Name");
            ViewBag.LeadTagId = new SelectList(_leadTagService.List().Where(m => m.Status).ToList(), "Id", "Name");
            ViewBag.UserId = new SelectList(getAgentList(), "Id", "Name");

            return View(lead);
        }

        [HttpPost]
        public JsonResult ReAssign(Dictionary<string, string> data)
        {
            var ids = data["ids"];
            var userId = data["userId"];

            var leadIds = ids.Split(',').Select(m => Convert.ToInt32(m)).ToArray();

            var leads = _leadService.ByIds(leadIds);
            foreach (var lead in leads)
            {
                lead.UserId = userId;
                lead.AssignedDate = DateTime.Now;
                _leadService.Update(lead);
            }
            return Json(new BaseResponse<string>() { Success = true });
        }

        private List<ApplicationUser> getAgentList()
        {
            var tid = base.getTidFromClaim();
            var users = _userManager.Users.Where(m => m.Tid == tid).Include(u => u.UserRoles).ThenInclude(ur => ur.Role).ToList();
            return users.Where(m => m.UserRoles.Any(m => m.Role.Name == UserType.Agent.ToString())).ToList();
        }
    }
}