using ProManager.Data.Repositories;
using ProManager.DataTransferObjects.Base;
using ProManager.Entities.Common;
using ProManager.IRepositories.Base;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace ProManager.Repositories.Base
{
    public class LanguagesRepository : BaseRepository<LanguagesDTO, Languages>, ILanguagesRepository
    {
        public LanguagesRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public override IQueryable<LanguagesDTO> GetAll(Expression<Func<LanguagesDTO, bool>> predicate = null)
        {
            var query = from q in DbContext.Languages
                        select new LanguagesDTO
                        {
                            Code = q.Code,
                            GlyphUrl = q.GlyphUrl,
                            Description = q.Description,
                            Id = q.Id,
                            ModifiedDate = q.ModifiedDate,
                            CreatedDate = q.CreatedDate,
                            IsDeleted = q.IsDeleted,
                            ApplicationUserId = q.ApplicationUserId,
                            RowVersion = q.RowVersion,
                        };

            if (predicate != null)
            {
                return query.Where(predicate);
            }
            else
            {
                return query;
            }
        }
    }
}
