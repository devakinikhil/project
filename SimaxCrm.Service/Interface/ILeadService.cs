using SimaxCrm.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SimaxCrm.Service.Interface
{
    public interface ILeadService
    {
        List<Lead> List();
        Lead ById(int id);
        void Create(Lead serviceType);
        void Update(Lead serviceType);
        void Delete(int id);
        bool IsAny(Expression<Func<Lead, bool>> predicate);
        List<Lead> ByUserId(Guid? userId, DateTime? startDate, DateTime? endDate);
        List<Lead> AllLeads();
        List<Lead> ByLeadStatusAndUserId(string leadStatus, Guid? userId, DateTime? startDate, DateTime? endDate);
        List<Lead> ByIds(int[] leadIds);
    }
}
