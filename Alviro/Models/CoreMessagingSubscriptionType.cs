using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class CoreMessagingSubscriptionType
{
    public int SubscriptionTypeId { get; set; }

    public string SubscriptionName { get; set; } = null!;

    public string FriendlyName { get; set; } = null!;

    public int? DesktopModuleId { get; set; }

    public virtual ICollection<CoreMessagingSubscription> CoreMessagingSubscriptions { get; set; } = new List<CoreMessagingSubscription>();
}
