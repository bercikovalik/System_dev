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


namespace Dnn.TegnapraKV.Dnn.TegnapraKV.KisegitoModul.Classes
{
    public class HelperController:DnnApiController
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
        public HttpResponseMessage GetRecipeDetail(int RecipeID)
        {
            try
            {
                var service = new RecipeDetailService();
                var details = service.GetRecipeDetail(RecipeID).ToJson();

                return Request.CreateResponse(HttpStatusCode.OK, details);
            }
            catch (Exception exc)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, exc);
            }
        }


        [AllowAnonymous]
        [HttpGet]
        public HttpResponseMessage GetRecipeIngredients(int RecipeID)
        {
            try
            {
                var service = new HozzavalokService();
                var details = service.GetRecipeIngredients(RecipeID).ToJson();

                return Request.CreateResponse(HttpStatusCode.OK, details);
            }
            catch (Exception exc)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, exc);
            }
        }


    }
}