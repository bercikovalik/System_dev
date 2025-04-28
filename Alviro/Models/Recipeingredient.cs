using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class Recipeingredient
{
    public int Recipeingredientid { get; set; }

    public int Recipeid { get; set; }

    public int Ingredientid { get; set; }

    public string? Quantity { get; set; }

    public virtual Ingredient Ingredient { get; set; } = null!;

    public virtual Recipe Recipe { get; set; } = null!;
}
