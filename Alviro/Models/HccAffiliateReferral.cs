using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class HccAffiliateReferral
{
    public long Id { get; set; }

    public long AffiliateId { get; set; }

    public string Referrerurl { get; set; } = null!;

    public DateTime TimeOfReferralUtc { get; set; }

    public long StoreId { get; set; }

    public virtual HccAffiliate Affiliate { get; set; } = null!;
}
