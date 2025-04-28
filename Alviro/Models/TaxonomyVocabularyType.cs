using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class TaxonomyVocabularyType
{
    public int VocabularyTypeId { get; set; }

    public string VocabularyType { get; set; } = null!;

    public virtual ICollection<TaxonomyVocabulary> TaxonomyVocabularies { get; set; } = new List<TaxonomyVocabulary>();
}
