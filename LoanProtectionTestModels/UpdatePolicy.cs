using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class UpdatePolicy
{
    public string? SchemNumber { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string IdDocumentNumber { get; set; } = null!;

    public string Pol { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;
}
