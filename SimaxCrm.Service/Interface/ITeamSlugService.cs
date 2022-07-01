using SimaxCrm.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SimaxCrm.Service.Interface
{
    public interface ITeamSlugService
    {
        List<TeamSlug> List();
        TeamSlug ById(int id);
        void Create(TeamSlug serviceType);
        void Update(TeamSlug serviceType);
        void Delete(int id);
        bool IsAny(Expression<Func<TeamSlug, bool>> predicate);
    }
}
