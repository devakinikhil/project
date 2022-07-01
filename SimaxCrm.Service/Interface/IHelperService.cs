using SimaxCrm.Model.Entity;
using SimaxCrm.Model.RequestModel;

namespace SimaxCrm.Service.Interface
{
    public interface IHelperService
    {
        bool SendText(SendTextModel sendTextModel, Lead lead, EmailSetup emailSetup, ref string result);
        bool TestEmail(string toEmail, EmailSetup emailSetup, out string errorMsg);
        string AssignAgentSourceAndRankingWise(int source);
    }
}
