using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class HccFraud
{
    public string Bvin { get; set; } = null!;

    public int RuleType { get; set; }

    public string RuleValue { get; set; } = null!;

    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }
}
