using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class HccProductOptionTranslation
{
    public long ProductOptionTranslationId { get; set; }

    public Guid ProductOptionId { get; set; }

    public string Culture { get; set; } = null!;

    public string? Name { get; set; }

    public string? TextSettings { get; set; }

    public virtual HccProductOption ProductOption { get; set; } = null!;
}
