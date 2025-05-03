using DotNetNuke.Web.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dnn.TegnapraKV.Dnn.TegnapraKV.KisegitoModul.Classes
{
    public class RouteMapperForDetails:IServiceRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapHttpRoute("Dnn.TegnapraKV.KisegitoModul", "default", "{controller}/{action}", new[] { "Dnn.TegnapraKV.Dnn.TegnapraKV.KisegitoModul.Classes" });
        }
    }
}