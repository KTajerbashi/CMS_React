
using CRM.EndPoint.WebApi.HostApp.StartApp;

StartApplication.RunApplication(() =>
{
    var builder = WebApplication.CreateBuilder(args);
    builder
    .ServiceConfiguration()
    .ConfigurePipeline();
});






