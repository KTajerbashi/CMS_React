using System;
using System.Security.Cryptography;

namespace CRM.EndPoint.WebApi.ApplicationBase.Entity;

public interface IEntity<TId>
{
    public TId Id { get; set; }
    public Guid Key { get; set; }
    bool IsDeleted { get; set; }
    bool IsActive { get; set; }
}
public abstract class Entity<TId> : IEntity<TId>
{
    public TId Id { get; set; }
    public Guid Key { get; set; }
    public bool IsDeleted { get; set; }
    public bool IsActive { get; set; }
}
public abstract class BaseEntity<TId> : Entity<TId>
    where TId : struct,
          IComparable,
          IComparable<TId>,
          IConvertible,
          IEquatable<TId>,
          IFormattable
{
    
    public bool IsDeleted { get; set; }
    public bool IsActive { get; set; }
}
public abstract class BaseEntity : BaseEntity<long>
{

}