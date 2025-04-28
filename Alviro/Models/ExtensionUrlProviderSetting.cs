using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class ExtensionUrlProviderSetting
{
    public int ExtensionUrlProviderId { get; set; }

    public int PortalId { get; set; }

    public string SettingName { get; set; } = null!;

    public string SettingValue { get; set; } = null!;
}
