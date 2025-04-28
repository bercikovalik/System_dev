using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class JournalDatum
{
    public int JournalDataId { get; set; }

    public int JournalId { get; set; }

    public string JournalXml { get; set; } = null!;

    public virtual Journal Journal { get; set; } = null!;
}
