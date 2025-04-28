using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class Recipe
{
    public int Recipeid { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? Instructions { get; set; }

    public DateTime Lastmodified { get; set; }

    public string? Imageurl { get; set; }

    public virtual ICollection<RecipeProductLink> RecipeProductLinks { get; set; } = new List<RecipeProductLink>();

    public virtual ICollection<Recipeingredient> Recipeingredients { get; set; } = new List<Recipeingredient>();
}
