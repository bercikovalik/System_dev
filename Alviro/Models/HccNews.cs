using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class HccNews
{
    public long Id { get; set; }

    public DateTime TimeStampUtc { get; set; }

    public string Message { get; set; } = null!;
}
