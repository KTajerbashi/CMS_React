namespace CRM.EndPoint.WebApi.ApplicationBase.Models;

public interface IBaseDTO<TId>
{
    TId Id { get; set; }
    Guid Key { get; set; }
}
public abstract class BaseDTO<TId> : IBaseDTO<TId>
{
    public TId Id { get; set; }
    public Guid Key { get; set; }
}
public abstract class BaseDTO : BaseDTO<long>
{

}