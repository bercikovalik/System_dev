using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class MetaData
{
    public int MetaDataId { get; set; }

    public string MetaDataName { get; set; } = null!;

    public string? MetaDataDescription { get; set; }

    public virtual ICollection<ContentItemsMetaDatum> ContentItemsMetaData { get; set; } = new List<ContentItemsMetaDatum>();
}
