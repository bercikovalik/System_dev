using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class HccStoreDomain
{
    public long Id { get; set; }

    public long StoreId { get; set; }

    public string DomainName { get; set; } = null!;
}
