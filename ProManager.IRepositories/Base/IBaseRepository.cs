using ProManager.DataTransferObjects.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ProManager.IRepositories.Base
{
    public interface IBaseRepository<T, TEntity> where T : IDTOModel<TEntity> where TEntity : class
    {
        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate = null);
        PagedResult<T> GetPaged(Expression<Func<T, bool>> predicate = null, Expression<Func<T, string>> sortpredicate = null, int page = 0, int pageSize = 10);

        T Add(T entity);
        IEnumerable<T> AddRange(IEnumerable<T> entities);
        IEnumerable<T> UpdateRange(IEnumerable<T> entities);
        void UpdateDependencies(T entity);
        void DeleteDependencies(T entity);
        bool DeleteRange(IEnumerable<Guid> ids);
        bool Delete(Guid id);
        T Update(T entity);
    }
}
