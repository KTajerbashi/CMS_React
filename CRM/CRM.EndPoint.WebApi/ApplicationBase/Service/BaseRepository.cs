using CRM.EndPoint.WebApi.ApplicationBase.Entity;
using CRM.EndPoint.WebApi.ApplicationBase.Repository;

namespace CRM.EndPoint.WebApi.ApplicationBase.Service;

public abstract class BaseRepository<TEntity, TContext, TId>
    : IBaseRepository<TEntity, TContext, TId>
    where TEntity : IEntity
    where TContext : IEntity
    where TId : struct, IComparable, IComparable<TId>, IConvertible, IEquatable<TId>, IFormattable
{

}
