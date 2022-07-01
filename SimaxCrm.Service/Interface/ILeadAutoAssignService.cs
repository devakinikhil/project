using SimaxCrm.Model.Entity;
using System.Collections.Generic;

namespace SimaxCrm.Service.Interface
{
    public interface ILeadAutoAssignService
    {
        List<LeadAutoAssign> List();
        LeadAutoAssign ById(int id);
        void Create(LeadAutoAssign serviceType);
        void Update(LeadAutoAssign serviceType);
        void Delete(int id);
    }
}
