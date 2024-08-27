using CRM.EndPoint.WebApi.ApplicationBase.Database;
using Microsoft.EntityFrameworkCore;

namespace CRM.EndPoint.WebApi.ApplicationBase.Pattern;

public interface IUnitOfWork : IDisposable
{
    Task<int> SaveChangeAsync();
    void BeginTransactionAsync();
    void CommitTransactionAsync();
    void RollBackTransactionAsync();
}
public abstract class UnitOfWork<TContext> : IUnitOfWork
    where TContext : BaseDatabaseContext
{
    protected TContext Context;

    protected UnitOfWork(TContext context)
    {
        Context = context;
    }

    public void BeginTransactionAsync()
    {
        Context.Database.BeginTransactionAsync();
    }

    public void CommitTransactionAsync()
    {
        Context.Database.CommitTransactionAsync();
    }

    public void Dispose()
    {
        Context.DisposeAsync();
    }

    public void RollBackTransactionAsync()
    {
        Context.Database.RollbackTransactionAsync();
    }

    public async Task<int> SaveChangeAsync()
    {
        return await Context.SaveChangesAsync();
    }
}
