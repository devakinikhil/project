using SimaxCrm.Data.BaseRepository;
using SimaxCrm.Model.Entity;

namespace SimaxCrm.Data.Repository.Interface
{
    public interface ITeamSlugRepository : IRepositoryBase<TeamSlug>
    {
        TeamSlug ByIdWithoutTeam(int id);
    }
}
