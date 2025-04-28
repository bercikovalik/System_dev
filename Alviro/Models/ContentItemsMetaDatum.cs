using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class ContentItemsMetaDatum
{
    public int ContentItemMetaDataId { get; set; }

    public int ContentItemId { get; set; }

    public int MetaDataId { get; set; }

    public string? MetaDataValue { get; set; }

    public virtual ContentItem ContentItem { get; set; } = null!;

    public virtual MetaData MetaData { get; set; } = null!;
}
