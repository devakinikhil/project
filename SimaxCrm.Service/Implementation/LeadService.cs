using SimaxCrm.Data.Repository.Interface;
using SimaxCrm.Model.Entity;
using SimaxCrm.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SimaxCrm.Service.Implementation
{
    public class LeadService : ILeadService
    {
        private readonly ILeadRepository _leadRepository;
        public LeadService(ILeadRepository leadRepository)
        {
            _leadRepository = leadRepository;
        }

        public void Create(Lead lead)
        {
            _leadRepository.Insert(lead);
        }

        public void Delete(int id)
        {
            var obj = _leadRepository.SearchFor(x => x.Id == id).FirstOrDefault();
            _leadRepository.Delete(obj);
        }

        public void Update(Lead lead)
        {
            _leadRepository.UpdateEntity(lead);
        }

        public List<Lead> List()
        {
            return _leadRepository.SearchFor(null, "LeadLanguage,LeadSource,User,LeadTagMapping,LeadTagMapping.LeadTag").OrderByDescending(x => x.Id).ToList();
        }

        public Lead ById(int id)
        {
            return _leadRepository.SearchFor(x => x.Id == id, "User,LeadTagMapping,CallLog,CallLog.User").FirstOrDefault();
        }

        public bool IsAny(Expression<Func<Lead, bool>> predicate)
        {
            return _leadRepository.SearchFor().Any(predicate);
        }

        public List<Lead> ByUserId(Guid? userId, DateTime? startDate, DateTime? endDate)
        {
            var query = _leadRepository.SearchFor(null, "LeadLanguage,LeadSource,User,LeadTagMapping,LeadTagMapping.LeadTag");
            if (userId.HasValue)
            {
                query = query.Where(m => m.UserId == userId.Value.ToString());
            }
            if (startDate.HasValue)
            {
                query = query.Where(m => m.CreatedDate.Date >= startDate.Value);
            }
            if (endDate.HasValue)
            {
                query = query.Where(m => m.CreatedDate.Date <= endDate.Value);
            }
            return query.ToList();
        }

        public List<Lead> AllLeads()
        {
            return _leadRepository.SearchFor(null).ToList();
        }

        public List<Lead> ByLeadStatusAndUserId(string leadStatus, Guid? userId, DateTime? startDate, DateTime? endDate)
        {
            var query = _leadRepository.SearchFor(x => x.LeadStatus == leadStatus, "LeadLanguage,LeadSource,User,LeadTagMapping,LeadTagMapping.LeadTag");
            if (userId.HasValue)
            {
                query = query.Where(m => m.UserId == userId.Value.ToString());
            }
            if (startDate.HasValue)
            {
                query = query.Where(m => m.CreatedDate.Date >= startDate.Value);
            }
            if (endDate.HasValue)
            {
                query = query.Where(m => m.CreatedDate.Date <= endDate.Value);
            }
            return query.ToList();
        }

        public List<Lead> ByIds(int[] leadIds)
        {
            return _leadRepository.SearchFor(m => leadIds.Contains(m.Id)).ToList();
        }
    }
}
