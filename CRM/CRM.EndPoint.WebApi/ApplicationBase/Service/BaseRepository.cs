using CRM.EndPoint.WebApi.ApplicationBase.Database;
using CRM.EndPoint.WebApi.ApplicationBase.Entity;
using CRM.EndPoint.WebApi.ApplicationBase.Pattern;
using CRM.EndPoint.WebApi.ApplicationBase.Repository;
using Microsoft.EntityFrameworkCore;

namespace CRM.EndPoint.WebApi.ApplicationBase.Service;

public abstract class BaseRepository<TEntity, TContext, TId>
    : UnitOfWork<TContext>, IBaseRepository<TEntity, TContext, TId>
    where TEntity : class, IEntity<TId>
    where TContext : BaseDatabaseContext
    where TId : struct, IComparable, IComparable<TId>, IConvertible, IEquatable<TId>, IFormattable
{
    protected BaseRepository(TContext context) : base(context)
    {
    }

    public Task Delete(TEntity entity)
        => Task.FromResult(Context.Set<TEntity>().Remove(entity));

    public async Task Delete(TId id)
        => await Delete(await Context.Set<TEntity>().FindAsync(id));

    public async Task Delete(Guid key)
    {
        var entity = await Context.Set<TEntity>().Where(item => item.Key.Equals(key)).FirstOrDefaultAsync();
        if (entity is null)
            throw new InvalidOperationException();//TODO Exception
        await Delete(entity);
    }

    public async Task<TEntity> GetAsync(TId id)
        => await GetQueryable().Where(item => item.Id.Equals(id)).FirstOrDefaultAsync();

    public async Task<TEntity> GetAsync(Guid key)
        => await GetQueryable().Where(item => item.Key.Equals(key)).FirstOrDefaultAsync();

    public async Task<IEnumerable<TEntity>> GetAsync() 
        => await GetQueryable().ToListAsync();

    public async Task<TId> Insert(TEntity entity)
    {
        await Context.Set<TEntity>().AddAsync(entity);
        return entity.Id;
    }
    public IQueryable<TEntity> GetQueryable()
    {
        return Context.Set<TEntity>().Where(item => item.IsActive && !item.IsDeleted).AsNoTracking().AsQueryable();
    }
}
