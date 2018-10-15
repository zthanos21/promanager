using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ProManager.Entities;
using ProManager.IRepositories.Base;
using ProManager.DataTransferObjects.Base;
using Microsoft.EntityFrameworkCore;

namespace ProManager.Data.Repositories
{
    public class BaseRepository<T, TEntity> : IBaseRepository<T, TEntity> where T : IDTOModel<TEntity> where TEntity : class
    {
        public IUnitOfWork _unitOfWork;

        public BaseRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        protected ProManagerContext DbContext
        {
            get { return _unitOfWork.DbContext; }
        }

        public T Add(T entity)
        {
            var m = entity.ToModel();
            var addedModel = this.DbContext.Set<TEntity>().Add(m);
            return entity;
        }

        public IEnumerable<T> AddRange(IEnumerable<T> entities)
        {
            foreach (var dto in entities)
            {
                Add(dto);
            }
            return entities;
        }

        public bool Delete(Guid id)
        {
            var entitytoRemove = DbContext.Set<TEntity>().Find(id);
            if (entitytoRemove != null)
            {
                //DeleteDependencies();
                DbContext.Set<TEntity>().Remove(entitytoRemove);
            }
            return true;
        }

        public virtual void DeleteDependencies(T entity)
        {

        }

        public bool DeleteRange(IEnumerable<Guid> ids)
        {
            try
            {
                foreach (var id in ids)
                {
                    Delete(id);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        //allways override
        public virtual IQueryable<T> GetAll(Expression<Func<T, bool>> predicate = null)
        {
            return null;
        }


        public virtual PagedResult<T> GetPaged(Expression<Func<T, bool>> predicate = null, Expression<Func<T, string>> sortpredicate = null, int page = 0, int pageSize = 10)
        {
            var query = GetAll(predicate);
            var result = new PagedResult<T>
            {
                CurrentPage = page,
                PageSize = pageSize,
                RowCount = query.Count()
            };
            var pageCount = (double)result.RowCount / pageSize;
            result.PageCount = (int)Math.Ceiling(pageCount);
            result.PageSize = pageSize;
            var skip = (page) * pageSize;
            result.Results = query.OrderBy(sortpredicate).Skip(skip).Take(pageSize).ToList();
            return result;
        }

        public T Update(T entity)
        {
            switch (entity.DTOState)
            {
                case Enumerators.DTOState.Unmodified:
                    break;
                case Enumerators.DTOState.Added:
                    this.Add(entity);
                    break;
                case Enumerators.DTOState.Modified:
                    var model = DbContext.Set<TEntity>().Find(entity.Id);
                    if (model != null)
                    {
                        entity.UpdateModel(model);
                        DbContext.Entry(model).State = EntityState.Modified;
                    }
                    break;
                case Enumerators.DTOState.Deleted:
                    Delete(entity.Id);
                    break;
            }
            entity.DTOState = Enumerators.DTOState.Unmodified;
            UpdateDependencies(entity);
            DeleteDependencies(entity);
            return entity;
        }

        public virtual void UpdateDependencies(T entity)
        {

        }

        public IEnumerable<T> UpdateRange(IEnumerable<T> entities)
        {
            var res = new HashSet<T>();
            foreach (var dto in entities)
            {
                res.Add(Update(dto));
            }
            return res;
        }
    }
}
