using System;
using System.Linq;
using System.Linq.Expressions;

namespace SimaxCrm.Data.BaseRepository
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate = null, string Include = null);
        T GetById(int id, bool isTracking = true);
        void Insert(T entity);
        void Delete(T entity);
        void Update();
        void UpdateEntity(T entity);


    }
}
