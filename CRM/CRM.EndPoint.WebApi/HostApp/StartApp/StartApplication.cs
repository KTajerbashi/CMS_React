namespace CRM.EndPoint.WebApi.HostApp.StartApp;

public class StartApplication
{
    public static void RunApplication(Action action)
    {
        action();
    }
}
