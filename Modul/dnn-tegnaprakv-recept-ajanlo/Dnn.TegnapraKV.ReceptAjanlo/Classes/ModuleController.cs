using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DotNetNuke.Entities.Tabs;
using DotNetNuke.Web.Api;
using System.Linq;
using System.Collections.Generic;
using DotNetNuke.Services.Connections;
using DotNetNuke.Common.Utilities;
using System.Web;


namespace dnn.tegnaprakv.Dnn.TegnapraKV.ReceptAjanlo.Classes
{
    public class ModuleController:DnnApiController
    {

        [AllowAnonymous]
        [HttpGet]
        public HttpResponseMessage HelloWorld()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Hello World!");
        }



    }
}