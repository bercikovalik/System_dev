using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class PackageDependency
{
    public int PackageDependencyId { get; set; }

    public int PackageId { get; set; }

    public string PackageName { get; set; } = null!;

    public string Version { get; set; } = null!;

    public virtual Package Package { get; set; } = null!;
}
