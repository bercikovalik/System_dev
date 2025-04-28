using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class SearchIndexer
{
    public int SearchIndexerId { get; set; }

    public string SearchIndexerAssemblyQualifiedName { get; set; } = null!;
}
