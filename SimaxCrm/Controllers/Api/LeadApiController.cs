using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SimaxCrm.Model.Entity;
using SimaxCrm.Model.Enum;
using SimaxCrm.Model.RequestModel;
using SimaxCrm.Model.ResponseModel;
using SimaxCrm.Service.Interface;
using System;
using System.Linq;

namespace SimaxCrm.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("api/lead")]
    public class LeadApiController : Controller
    {
        private readonly ILeadService _leadService;
        private readonly ILeadSourceService _leadSourceService;
        private readonly ILeadAutoAssignLogService _leadAutoAssignLogService;
        private readonly ILeadLanguageService _leadLanguageService;
        private readonly IHelperService _helperService;

        public LeadApiController(
            ILeadService leadService,
            ILeadSourceService leadSourceService,
            IHelperService helperService,
            ILeadAutoAssignLogService leadAutoAssignLogService,
            ILeadLanguageService leadLanguageService
            )
        {
            _helperService = helperService;
            _leadService = leadService;
            _leadSourceService = leadSourceService;
            _leadAutoAssignLogService = leadAutoAssignLogService;
            _leadLanguageService = leadLanguageService;
        }

        [HttpPost]
        [Route("create")]
        public JsonResult Create(LeadModel obj)
        {
            var result = new BaseResponse<string>();
            result.Success = false;
            if (string.IsNullOrEmpty(obj.Name))
            {
                result.Response = "Name is required";
                return Json(result);
            }
            if (string.IsNullOrEmpty(obj.PhoneNumber))
            {
                result.Response = "Phone Number is required";
                return Json(result);
            }
            if (string.IsNullOrEmpty(obj.Source))
            {
                result.Response = "Source is required";
                return Json(result);
            }

            var leadSource = _leadSourceService.ByName(obj.Source);
            if (leadSource != null)
            {
                var userId = _helperService.AssignAgentSourceAndRankingWise(leadSource.Id);
                if (!string.IsNullOrEmpty(userId))
                {
                    var lead = new Lead()
                    {
                        UserId = userId,
                        CreatedDate = DateTime.Now,
                        AssignedDate = DateTime.Now,
                        LeadStatus = LeadStatusType.NewLead.ToString(),
                        PhoneNumber = obj.PhoneNumber,
                        Email = obj.Email,
                        Name = obj.Name,
                        LeadSourceId = leadSource.Id,
                        LeadLanguageId = _leadLanguageService.List().FirstOrDefault().Id
                    };
                    _leadService.Create(lead);

                    var leadAutoAssignLog = new LeadAutoAssignLog()
                    {
                        Id = 0,
                        LeadId = lead.Id,
                        LeadSourceId = leadSource.Id,
                        UserId = userId,
                        CreatedDate = DateTime.Now
                    };
                    _leadAutoAssignLogService.Create(leadAutoAssignLog);
                    result.Success = true;
                    result.Response = "Lead created.";
                }
                else
                {
                    result.Response = "Agent not available";
                }
            }
            else
            {
                result.Response = "Invalid Source";
            }
            return Json(result);
        }
    }
}