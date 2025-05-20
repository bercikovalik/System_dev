using dnn.tegnaprakv.Dnn.TegnapraKV.ReceptAjanlo.Classes;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnn.tegnaprakvDnn.TegnapraKV.ReceptAjanlo.Classes
{
    internal class RandomRecipeService
    {

        public IList<Recipe> GetRandomRecipes()
        {
            return CBO.FillCollection<Recipe>(DataProvider.Instance().ExecuteReader("GetRandomRecipe"));
        }

    }
}
