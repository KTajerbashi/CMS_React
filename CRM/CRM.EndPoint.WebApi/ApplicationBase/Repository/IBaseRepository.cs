using CRM.EndPoint.WebApi.ApplicationBase.Database;
using CRM.EndPoint.WebApi.ApplicationBase.Entity;
using CRM.EndPoint.WebApi.ApplicationBase.Pattern;

namespace CRM.EndPoint.WebApi.ApplicationBase.Repository;

public interface IBaseRepository<TEntity, TContext, TId> : IUnitOfWork
    where TEntity : IEntity<TId>
    where TContext : BaseDatabaseContext
    where TId : struct,
          IComparable,
          IComparable<TId>,
          IConvertible,
          IEquatable<TId>,
          IFormattable
{

    Task<TId> Insert(TEntity entity);


    Task Delete(TEntity entity);
    Task Delete(TId id);
    Task Delete(Guid key);


    Task<TEntity> GetAsync(TId id);
    Task<TEntity> GetAsync(Guid key);
    Task<IEnumerable<TEntity>> GetAsync();
}
