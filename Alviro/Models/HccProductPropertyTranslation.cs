using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class HccProductPropertyTranslation
{
    public long ProductPropertyTranslationId { get; set; }

    public long ProductPropertyId { get; set; }

    public string Culture { get; set; } = null!;

    public string? DisplayName { get; set; }

    public string? DefaultLocalizableValue { get; set; }

    public virtual HccProductProperty ProductProperty { get; set; } = null!;
}
