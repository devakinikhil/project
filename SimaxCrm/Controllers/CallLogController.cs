using Microsoft.AspNetCore.Mvc;
using SimaxCrm.Model.Entity;
using SimaxCrm.Model.Enum;
using SimaxCrm.Model.ResponseModel;
using SimaxCrm.Service.Interface;
using System;

namespace SimaxCrm.Controllers
{
    public class CallLogController : BaseController
    {
        private readonly ICallLogService _callLogService;
        private readonly ILeadService _leadService;

        public CallLogController(ICallLogService callLogService,
            ILeadService leadService)
        {
            _callLogService = callLogService;
            _leadService = leadService;
        }

        [HttpPost]
        public JsonResult Update(CallLog callLog)
        {
            var result = new BaseResponse<string>();
            var uid = (Guid)base.getUidFromClaim();

            if (callLog.Id == 0)
            {
                callLog.CreatedDate = DateTime.Now;
                callLog.UserId = uid.ToString();
                _callLogService.Create(callLog);
            }

            var lead = _leadService.ById(callLog.LeadId);
            lead.LastContact = DateTime.Now;
            if (callLog.Status != LeadStatusType.Comment.ToString())
                lead.LeadStatus = callLog.Status;
            if (callLog.AlertDate.HasValue)
                lead.AlertDate = callLog.AlertDate;

            if (callLog.Status == LeadStatusType.Reopen.ToString())
                lead.AssignedDate = DateTime.Now;

            _leadService.Update(lead);

            result.Success = true;
            return Json(result);
        }
    }
}
