using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class Ingredientproduct
{
    public int Ingredientproductid { get; set; }

    public int Ingredientid { get; set; }

    public int Productid { get; set; }

    public string? RewriteUrl { get; set; }

    public virtual Ingredient Ingredient { get; set; } = null!;
}
