using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class HccMembershipProductType
{
    public Guid ProductTypeBvin { get; set; }

    public string RoleName { get; set; } = null!;

    public int ExpirationPeriod { get; set; }

    public int ExpirationPeriodType { get; set; }

    public bool Notify { get; set; }

    public virtual HccProductType ProductTypeBvinNavigation { get; set; } = null!;
}
