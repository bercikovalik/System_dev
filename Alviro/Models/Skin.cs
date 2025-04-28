using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class Skin
{
    public int SkinId { get; set; }

    public int SkinPackageId { get; set; }

    public string SkinSrc { get; set; } = null!;

    public virtual SkinPackage SkinPackage { get; set; } = null!;
}
