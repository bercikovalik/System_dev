using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class HccContentBlockTranslation
{
    public long ContentBlockTranslationId { get; set; }

    public Guid ContentBlockId { get; set; }

    public string Culture { get; set; } = null!;

    public string? TextSettings { get; set; }

    public virtual HccContentBlock ContentBlock { get; set; } = null!;
}
