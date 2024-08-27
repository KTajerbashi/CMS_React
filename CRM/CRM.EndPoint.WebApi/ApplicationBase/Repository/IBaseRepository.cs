using CRM.EndPoint.WebApi.ApplicationBase.Entity;
using System;

namespace CRM.EndPoint.WebApi.ApplicationBase.Repository;

public interface IBaseRepository<TEntity, TContext, TId>
    where TEntity : IEntity
    where TContext : IEntity
    where TId : struct,
          IComparable,
          IComparable<TId>,
          IConvertible,
          IEquatable<TId>,
          IFormattable
{
}
