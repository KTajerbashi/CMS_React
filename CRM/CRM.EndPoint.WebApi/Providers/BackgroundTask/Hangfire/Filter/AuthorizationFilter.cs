using Hangfire.Annotations;
using Hangfire.Dashboard;

namespace CRM.EndPoint.WebApi.Providers.BackgroundTask.Hangfire.Filter;

public class AuthorizationFilter : IDashboardAuthorizationFilter
{
    private string role;
    public AuthorizationFilter(string role)
    {
        this.role = role;
    }
    public bool Authorize([NotNull] DashboardContext context)
    {
        var httpContext = context.GetHttpContext();
#if DEBUG
        return httpContext.Connection.RemoteIpAddress.Equals(httpContext.Connection.LocalIpAddress);
#else
       return httpContext.User.Identity.IsAuthenticated && httpContext.User.IsInRole(role);
#endif
    }
}

