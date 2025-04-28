using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class Ingredient
{
    public int Ingredientid { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Ingredientproduct> Ingredientproducts { get; set; } = new List<Ingredientproduct>();

    public virtual ICollection<Recipeingredient> Recipeingredients { get; set; } = new List<Recipeingredient>();
}
