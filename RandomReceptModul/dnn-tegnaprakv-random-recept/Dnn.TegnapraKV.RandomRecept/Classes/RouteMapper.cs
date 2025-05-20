using DotNetNuke.Web.Api;

public class RouteMapper : IServiceRouteMapper
{
    public void RegisterRoutes(IMapRoute mapRouteManager)
    {
        mapRouteManager.MapHttpRoute("Dnn.TegnapraKV.RandomRecept", "default", "{controller}/{action}", new[] { "Dnn.TegnapraKV.Dnn.TegnapraKV.RandomRecept.Classes" });
    }
}