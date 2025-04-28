using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class RecipeProductLink
{
    public int RecipeProductLinkId { get; set; }

    public int RecipeId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal Quantity { get; set; }

    public string? Unit { get; set; }

    public int? ProductTypeId { get; set; }

    public virtual ProductType? ProductType { get; set; }

    public virtual Recipe Recipe { get; set; } = null!;
}
