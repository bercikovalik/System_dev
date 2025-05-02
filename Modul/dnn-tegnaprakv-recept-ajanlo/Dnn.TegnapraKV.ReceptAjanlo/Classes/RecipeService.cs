using DotNetNuke.Common.Utilities;
using DotNetNuke.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dnn.tegnaprakv.Dnn.TegnapraKV.ReceptAjanlo.Classes
{
    public class RecipeService
    {

        public IList<Recipe> GetRecipes(string RewriteURLs)
        {
            return CBO.FillCollection<Recipe>(DataProvider.Instance().ExecuteReader("GetTop5RecipesByProducts", RewriteURLs));
        }


    }
}