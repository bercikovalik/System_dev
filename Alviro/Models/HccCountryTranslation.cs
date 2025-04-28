using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class HccCountryTranslation
{
    public long CountryTranslationId { get; set; }

    public Guid CountryId { get; set; }

    public string Culture { get; set; } = null!;

    public string? DisplayName { get; set; }

    public virtual HccCountry Country { get; set; } = null!;
}
