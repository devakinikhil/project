using SimaxCrm.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SimaxCrm.Service.Interface
{
    public interface ILeadSourceService
    {
        List<LeadSource> List();
        LeadSource ById(int id);
        void Create(LeadSource serviceType);
        void Update(LeadSource serviceType);
        void Delete(int id);
        bool IsAny(Expression<Func<LeadSource, bool>> predicate);
        LeadSource ByName(string source);
    }
}
