using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dnn.tegnaprakv.Dnn.TegnapraKV.ReceptAjanlo.Classes
{
    public class Recipe
    {
        public int RecipeID { get; set; }
        public string RecipeName { get; set; }
        public string ImageUrl { get; set; }
        public int MatchCount { get; set; }
    }
}