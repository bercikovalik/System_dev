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
using dnn.tegnaprakvDnn.TegnapraKV.ReceptAjanlo.Classes;



namespace dnn.tegnaprakv.Dnn.TegnapraKV.ReceptAjanlo.Classes
{
    public class ModuleController:DnnApiController
    {
        //Irreleváns de itt maradhat
        [AllowAnonymous]
        [HttpGet]
        public HttpResponseMessage HelloWorld()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Hello World!");
        }
        /////////////////////////////////////////////////////////////////////


        [AllowAnonymous]
        [HttpGet]
        public HttpResponseMessage GetRecipes(string RewriteURLs)
        {
            try
            {
                var service = new RecipeService();
                var tasks = service.GetRecipes(RewriteURLs).ToJson();

                return Request.CreateResponse(HttpStatusCode.OK, tasks);
            }
            catch (Exception exc)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, exc);
            }
        }


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