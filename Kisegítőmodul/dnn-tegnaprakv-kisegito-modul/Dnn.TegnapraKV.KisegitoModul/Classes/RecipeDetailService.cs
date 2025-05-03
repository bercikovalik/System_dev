using DotNetNuke.Common.Utilities;
using DotNetNuke.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dnn.TegnapraKV.Dnn.TegnapraKV.KisegitoModul.Classes
{
    public class RecipeDetailService
    {

        public RecipeDetail GetRecipeDetail(int RecipeID)
        {
            return CBO.FillObject<RecipeDetail>(DataProvider.Instance().ExecuteReader("GetRecipeDetails", RecipeID));
        }



    }
}