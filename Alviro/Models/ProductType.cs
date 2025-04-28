using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class ProductType
{
    public int ProductTypeId { get; set; }

    public string TypeName { get; set; } = null!;

    public virtual ICollection<RecipeProductLink> RecipeProductLinks { get; set; } = new List<RecipeProductLink>();
}
