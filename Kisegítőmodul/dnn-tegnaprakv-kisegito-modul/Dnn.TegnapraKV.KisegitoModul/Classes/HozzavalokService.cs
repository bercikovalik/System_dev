using DotNetNuke.Common.Utilities;
using DotNetNuke.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dnn.TegnapraKV.Dnn.TegnapraKV.KisegitoModul.Classes
{
    public class HozzavalokService
    {


        public IList<Ingredients> GetRecipeIngredients(int RecipeID)
        {
            return CBO.FillCollection<Ingredients>(DataProvider.Instance().ExecuteReader("GetIngredientsByRecipeId", RecipeID));
        }



    }
}