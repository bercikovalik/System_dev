using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class HccProductPropertyChoiceTranslation
{
    public long ProductPropertyChoiceTranslationId { get; set; }

    public long ProductPropertyChoiceId { get; set; }

    public string Culture { get; set; } = null!;

    public string? DisplayName { get; set; }

    public virtual HccProductPropertyChoice ProductPropertyChoice { get; set; } = null!;
}
