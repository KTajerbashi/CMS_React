namespace CRM.EndPoint.WebApi.Providers.MapperProvider.Abstraction;

public interface IMapperAdapter
{
    TDestination Map<TSource, TDestination>(TSource source);
}
