using DotNetNuke.Common.Utilities;
using DotNetNuke.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dnn.TegnapraKV.Dnn.TegnapraKV.KisegitoModul.Classes
{
    public class ProductService
    {
        public IList<Products> GetProducts(int RecipeID,string rewriteURLs)
        {
            return CBO.FillCollection<Products>(DataProvider.Instance().ExecuteReader("GetIngredientsByRecipeId", RecipeID));
        }



    }
}