using DotNetNuke.Web.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotNetNuke.Web.Api;

namespace dnn.tegnaprakv.Dnn.TegnapraKV.ReceptAjanlo.Classes
{
    public class RouteMapper:IServiceRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapHttpRoute("Dnn.TegnapraKV.ReceptAjanlo", "default", "{controller}/{action}", new[] { "dnn.tegnaprakv.Dnn.TegnapraKV.ReceptAjanlo.Classes" });
        }
    }
}