using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class PartnersDocumentRequired
{
    public int IdRecord { get; set; }

    public string DocId { get; set; } = null!;

    public string? DocumentRequired { get; set; }

    public string? Nature { get; set; }

    public int? ValYears { get; set; }
}
