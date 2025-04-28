using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class HccStoresXuser
{
    public long Id { get; set; }

    public long StoreId { get; set; }

    public long UserId { get; set; }

    public int AccessMode { get; set; }

    public virtual HccStore Store { get; set; } = null!;

    public virtual HccUserAccount User { get; set; } = null!;
}
