using DotNetNuke.Common.Utilities;
using DotNetNuke.Data;
using System.Collections.Generic;

namespace Dnn.TegnapraKV.Dnn.TegnapraKV.RandomRecept.Classes
{
    internal class RandomRecipeService
    {

        public IList<RandomRecipe> GetRandomRecipes()
        {
            return CBO.FillCollection<RandomRecipe>(DataProvider.Instance().ExecuteReader("GetRandomRecipe"));
        }

    }

}