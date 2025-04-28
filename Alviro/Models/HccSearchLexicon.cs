using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class HccSearchLexicon
{
    public long Id { get; set; }

    public string Word { get; set; } = null!;

    public string? Culture { get; set; }

    public virtual ICollection<HccSearchObjectWord> HccSearchObjectWords { get; set; } = new List<HccSearchObjectWord>();
}
