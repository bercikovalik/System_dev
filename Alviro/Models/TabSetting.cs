using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class TabSetting
{
    public int TabId { get; set; }

    public string SettingName { get; set; } = null!;

    public string SettingValue { get; set; } = null!;

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public virtual Tab Tab { get; set; } = null!;
}
