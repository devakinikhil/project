using Microsoft.AspNetCore.Http;
using SimaxCrm.Data.BaseRepository;
using SimaxCrm.Data.Context;
using SimaxCrm.Model.Entity;
using System.Linq;

namespace SimaxCrm.Data.Repository.Interface
{
    public class TeamSlugRepository : RepositoryBase<TeamSlug>, ITeamSlugRepository
    {
        public TeamSlugRepository(ApplicationDbContext applicationDbContext, IHttpContextAccessor httpContextAccessor) : base(applicationDbContext, httpContextAccessor)
        {

        }

        public TeamSlug ByIdWithoutTeam(int id)
        {
            return _applicationDbContext.TeamSlug.FirstOrDefault(m => m.Id == id);
        }
    }
}
