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
using System.Web.Mvc;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using AllowAnonymousAttribute = System.Web.Http.AllowAnonymousAttribute;



namespace Dnn.TegnapraKV.Dnn.TegnapraKV.RandomRecept.Classes
{
    public class RandomController : DnnApiController
    {
        [AllowAnonymous]
        [HttpGet]
        public HttpResponseMessage GetRandomRecipe()
        {
            try
            {
                var service = new RandomRecipeService();
                var tasks = service.GetRandomRecipes().ToJson();

                return Request.CreateResponse(HttpStatusCode.OK, tasks);
            }
            catch (Exception exc)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, exc);
            }
        }


    }
}
