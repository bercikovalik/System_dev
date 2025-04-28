using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class HccContentColumn
{
    public Guid Bvin { get; set; }

    public string DisplayName { get; set; } = null!;

    public int SystemColumn { get; set; }

    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    public virtual ICollection<HccContentBlock> HccContentBlocks { get; set; } = new List<HccContentBlock>();
}
