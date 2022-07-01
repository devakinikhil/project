using SimaxCrm.Data.Repository.Interface;
using SimaxCrm.Model.Entity;
using SimaxCrm.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SimaxCrm.Service.Implementation
{
    public class TeamSlugService : ITeamSlugService
    {
        private readonly ITeamSlugRepository _teamSlugRepository;
        public TeamSlugService(ITeamSlugRepository teamSlugRepository)
        {
            _teamSlugRepository = teamSlugRepository;
        }

        public void Create(TeamSlug teamSlug)
        {
            _teamSlugRepository.Insert(teamSlug);
        }

        public void Delete(int id)
        {
            var obj = _teamSlugRepository.SearchFor(x => x.Id == id).FirstOrDefault();
            _teamSlugRepository.Delete(obj);
        }

        public void Update(TeamSlug teamSlug)
        {
            _teamSlugRepository.UpdateEntity(teamSlug);
        }

        public List<TeamSlug> List()
        {
            return _teamSlugRepository.SearchFor().OrderByDescending(x => x.Id).ToList();
        }

        public TeamSlug ById(int id)
        {
            return _teamSlugRepository.ByIdWithoutTeam(id);
        }

        public bool IsAny(Expression<Func<TeamSlug, bool>> predicate)
        {
            return _teamSlugRepository.SearchFor(predicate).Any();
        }
    }
}
