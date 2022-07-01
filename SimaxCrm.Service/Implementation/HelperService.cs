using SimaxCrm.Model.Entity;
using SimaxCrm.Model.RequestModel;
using SimaxCrm.Service.Interface;
using System;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace SimaxCrm.Service.Implementation
{
    public class HelperService : IHelperService
    {
        private readonly ILeadAutoAssignService _leadAutoAssignService;
        private readonly ILeadAutoAssignLogService _leadAutoAssignLogService;

        public HelperService(ILeadAutoAssignService leadAutoAssignService,
            ILeadAutoAssignLogService leadAutoAssignLogService)
        {
            _leadAutoAssignService = leadAutoAssignService;
            _leadAutoAssignLogService = leadAutoAssignLogService;
        }

        public bool SendText(SendTextModel sendTextModel, Lead lead, EmailSetup emailSetup, ref string result)
        {
            try
            {
                if (sendTextModel.LogType == Model.Enum.TemplateType.Email)
                {
                    sendEmailMethod(lead.Email, sendTextModel.LogSubject, sendTextModel.LogText, emailSetup);
                    return true;
                }
                else
                {
                    return sendSMSMethod(lead.PhoneNumber, sendTextModel.LogText, ref result);
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
                return false;
            }
        }

        private bool sendSMSMethod(string phoneNumber, string logText, ref string result)
        {
            result = "api not configured";
            return false;
        }

        private static void sendEmailMethod(string toEmail, string subject, string content, EmailSetup emailSetup)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            message.From = new MailAddress(emailSetup.Email);
            message.To.Add(new MailAddress(toEmail));
            message.Subject = subject;
            message.IsBodyHtml = true; //to make message body as html  
            message.Body = content;
            smtp.Port = emailSetup.SmtpPort;
            smtp.Host = emailSetup.SmtpServer; //for gmail host  
            smtp.EnableSsl = emailSetup.UseSsl == "Yes";
            smtp.UseDefaultCredentials = false;
            if (!string.IsNullOrEmpty(emailSetup.Username) && !string.IsNullOrEmpty(emailSetup.Password))
            {
                smtp.Credentials = new NetworkCredential(emailSetup.Username, emailSetup.Password);
            }
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);
        }

        public bool TestEmail(string toEmail, EmailSetup emailSetup, out string errorMsg)
        {
            try
            {
                sendEmailMethod(toEmail, "Email Testing " + DateTime.Now.ToFileTime(), "Email Testing Body", emailSetup);
                errorMsg = "Sent";
                return true;
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;
                return false;
            }
        }

        public string AssignAgentSourceAndRankingWise(int source)
        {
            var allAutoAssignData = _leadAutoAssignService.List().Where(m => m.Status).ToList();
            var matchedAutoAssignData = allAutoAssignData.Where(m => m.LeadAutoAssignSourceMapping.Any(x => x.LeadSourceId == source)).OrderBy(m => m.UserId).ToList();

            var leadAutoAssignLogs = _leadAutoAssignLogService.ListByDate(DateTime.Now.Date);
            var logsGroupByUser = (from m in leadAutoAssignLogs
                                   group m by m.UserId into gg
                                   select new
                                   {
                                       UserId = gg.Key,
                                       Count = gg.Count()
                                   }).ToList().OrderBy(m => m.Count).ToList();

            var margeLogAndUser = (from a in matchedAutoAssignData
                                   join l in logsGroupByUser on a.UserId equals l.UserId into ll
                                   from l in ll.DefaultIfEmpty()
                                   select new
                                   {
                                       a.UserId,
                                       Count = l == null ? 0 : l.Count,
                                       a.HandleQuery
                                   }).ToList()
                                   .Where(m => m.Count < m.HandleQuery)
                                   .OrderBy(m => m.Count).ThenBy(m => m.UserId).ToList();

            var validUser = margeLogAndUser.FirstOrDefault();
            return validUser != null ? validUser.UserId : null;
        }
    }
}
