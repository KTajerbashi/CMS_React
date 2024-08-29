using CRM.EndPoint.WebApi.ApplicationBase.Database;
using CRM.EndPoint.WebApi.ApplicationBase.Entity;
using CRM.EndPoint.WebApi.ApplicationBase.Models;
using CRM.EndPoint.WebApi.ApplicationBase.Pattern;

namespace CRM.EndPoint.WebApi.ApplicationBase.Repository;

public interface IBaseRepository<TEntity, TContext, TId, TDTO> : IUnitOfWork
    where TEntity : IEntity<TId>
    where TContext : BaseDatabaseContext
    where TId : struct, IComparable, IComparable<TId>, IConvertible, IEquatable<TId>, IFormattable
    where TDTO : BaseDTO<TId>
{

    Task<TId> InsertAsync(TDTO entity);


    Task DeleteAsync(TDTO entity);
    Task DeleteAsync(TId id);
    Task DeleteAsync(Guid key);


    Task<TDTO> GetAsync(TId id);
    Task<TDTO> GetAsync(Guid key);
    Task<IEnumerable<TDTO>> GetAsync();
    IQueryable<TEntity> GetQueryable();
}
