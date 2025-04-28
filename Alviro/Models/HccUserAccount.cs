using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class HccUserAccount
{
    public long Id { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public int Statuscode { get; set; }

    public string Salt { get; set; } = null!;

    public string ResetKey { get; set; } = null!;

    public virtual ICollection<HccAuthToken> HccAuthTokens { get; set; } = new List<HccAuthToken>();

    public virtual ICollection<HccStoresXuser> HccStoresXusers { get; set; } = new List<HccStoresXuser>();
}
