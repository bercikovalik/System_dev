using DotNetNuke.Web.Api;

public class RouteMapper : IServiceRouteMapper
{
    public void RegisterRoutes(IMapRoute mapRouteManager)
    {
        mapRouteManager.MapHttpRoute("Dnn.TegnapraKV.RandomRecept", "default", "{controller}/{action}", new[] { "dnn.tegnaprakv.Dnn.TegnapraKV.RandomRecept.Classes" });
    }
}