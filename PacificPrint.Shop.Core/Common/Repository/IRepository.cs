using PacificPrint.Shop.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace PacificPrint.Shop.Core.Common_Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetQueryable(bool isTracking = true);

        Task AddAsync(TEntity entity, CancellationToken cancellationToken = default);

        Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);

        bool Delete(TEntity entity);

        void DeleteRange(IEnumerable<TEntity> entities);

        void DeleteRange(Expression<Func<TEntity, bool>> predicate);

        Task<bool> DeleteAsync(object[] keys, CancellationToken cancellationToken = default);

        bool Update(TEntity entity);

        void UpdateRange(IEnumerable<TEntity> entities);

        void UpdateRange(Expression<Func<TEntity, bool>> predicate, Action<TEntity> updateAction);

        Task<TEntity?> FindAsync(object[] keys, CancellationToken cancellationToken = default);

        Task<TEntity?> FindAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);

        Task<IEnumerable<TEntity>> GetListAsync(CancellationToken cancellationToken = default);

        Task<IEnumerable<TEntity>> GetListAsync(PageParameter parameter, CancellationToken cancellationToken = default);

        Task<IEnumerable<TEntity>> GetListAsync(int pageNum, int pageSize, CancellationToken cancellationToken = default);

        Task<IEnumerable<TEntity>> GetListAsync(
             Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);

        Task<IEnumerable<TEntity>> GetListAsync(
            Expression<Func<TEntity, bool>> predicate, PageParameter parameter, CancellationToken cancellationToken = default);

        Task<IEnumerable<TEntity>> GetListAsync(
            Expression<Func<TEntity, bool>> predicate, int pageNum, int pageSize, CancellationToken cancellationToken = default);

        Task<int> CountAsync(CancellationToken cancellationToken = default);

        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);

        Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);
    }
}
