using System;

namespace CRM.EndPoint.WebApi.ApplicationBase.Entity;

public interface IEntity
{
    bool IsDeleted { get; set; }
    bool IsActive { get; set; }
}
public abstract class Entity : IEntity
{
    public bool IsDeleted { get; set; }
    public bool IsActive { get; set; }
}
public abstract class BaseEntity<TId> : Entity
{
    public TId Id { get; set; }
    public Guid Key { get; set; }
    public bool IsDeleted { get; set; }
    public bool IsActive { get; set; }
}
public abstract class BaseEntity : BaseEntity<long>
{

}