using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class HccStoreSettingsTranslation
{
    public long StoreSettingsTranslationId { get; set; }

    public long StoreSettingsId { get; set; }

    public string Culture { get; set; } = null!;

    public string? LocalizedSettingValue { get; set; }

    public virtual HccStoreSetting StoreSettings { get; set; } = null!;
}
