using CRM.EndPoint.WebApi.ApplicationBase.Database;
using CRM.EndPoint.WebApi.ApplicationBase.Entity;
using CRM.EndPoint.WebApi.ApplicationBase.Models;
using CRM.EndPoint.WebApi.ApplicationBase.Pattern;
using CRM.EndPoint.WebApi.ApplicationBase.Repository;
using CRM.EndPoint.WebApi.Providers.MapperProvider.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace CRM.EndPoint.WebApi.ApplicationBase.Service;

public abstract class BaseRepository<TEntity, TContext, TId, TDTO>
    : UnitOfWork<TContext>, IBaseRepository<TEntity, TContext, TId, TDTO>
    where TEntity : class, IEntity<TId>
    where TContext : BaseDatabaseContext
    where TId : struct, IComparable, IComparable<TId>, IConvertible, IEquatable<TId>, IFormattable
    where TDTO : BaseDTO<TId>
{
    protected IMapperAdapter MapperAdapter;
    protected BaseRepository(TContext context, IMapperAdapter mapperAdapter) : base(context)
    {
        MapperAdapter = mapperAdapter;
    }
    private TEntity GetEntity(TDTO model)
        => MapperAdapter.Map<TDTO, TEntity>(model);
    private TDTO GetDTO(TEntity entity)
        => MapperAdapter.Map<TEntity, TDTO>(entity);

    public Task DeleteAsync(TDTO model)
        => Task.FromResult(Context.Set<TEntity>().Remove(GetEntity(model)));

    public async Task DeleteAsync(TId id)
        => await DeleteAsync(GetDTO(await Context.Set<TEntity>().FindAsync(id)));

    public async Task DeleteAsync(Guid key)
    {
        var entity = await Context.Set<TEntity>().Where(item => item.Key.Equals(key)).FirstOrDefaultAsync();
        if (entity is null)
            throw new InvalidOperationException();//TODO Exception
        await DeleteAsync(GetDTO(entity));
    }

    public async Task<TDTO> GetAsync(TId id)
    {
        var entity = await GetQueryable().Where(item => item.Id.Equals(id)).FirstOrDefaultAsync();
        return GetDTO(entity);
    }

    public async Task<TDTO> GetAsync(Guid key)
    {
        var entity = await GetQueryable().Where(item => item.Key.Equals(key)).FirstOrDefaultAsync();
        return GetDTO(entity);
    }

    public async Task<IEnumerable<TDTO>> GetAsync()
    {
        var dataList = await GetQueryable().ToListAsync();
        var result = MapperAdapter.Map<List<TEntity>,List<TDTO>>(dataList);
        return result.ToList();
    }

    public async Task<TId> InsertAsync(TDTO model)
    {
        var entity = GetEntity(model);
        await Context.Set<TEntity>().AddAsync(entity);
        return entity.Id;
    }
    public IQueryable<TEntity> GetQueryable()
        => Context
            .Set<TEntity>()
            .Where(item => item.IsActive && !item.IsDeleted)
            .AsNoTracking()
            .AsQueryable();
}
