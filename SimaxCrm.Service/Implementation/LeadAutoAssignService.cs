using SimaxCrm.Data.Repository.Interface;
using SimaxCrm.Model.Entity;
using SimaxCrm.Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace SimaxCrm.Service.Implementation
{
    public class LeadAutoAssignService : ILeadAutoAssignService
    {
        private readonly ILeadAutoAssignRepository _leadAutoAssignRepository;
        public LeadAutoAssignService(ILeadAutoAssignRepository leadAutoAssignRepository)
        {
            _leadAutoAssignRepository = leadAutoAssignRepository;
        }

        public void Create(LeadAutoAssign leadAutoAssign)
        {
            _leadAutoAssignRepository.Insert(leadAutoAssign);
        }

        public void Delete(int id)
        {
            var obj = _leadAutoAssignRepository.SearchFor(x => x.Id == id).FirstOrDefault();
            _leadAutoAssignRepository.Delete(obj);
        }

        public void Update(LeadAutoAssign leadAutoAssign)
        {
            _leadAutoAssignRepository.UpdateEntity(leadAutoAssign);
        }

        public List<LeadAutoAssign> List()
        {
            return _leadAutoAssignRepository.SearchFor(m => m.Status, "User,LeadAutoAssignSourceMapping,LeadAutoAssignSourceMapping.LeadSource").OrderByDescending(x => x.Id).ToList();
        }

        public LeadAutoAssign ById(int id)
        {
            return _leadAutoAssignRepository.SearchFor(x => x.Id == id, "LeadAutoAssignSourceMapping").FirstOrDefault();
        }


    }
}
