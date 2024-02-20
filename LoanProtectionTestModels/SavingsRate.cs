using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class SavingsRate
{
    public int IdRecord { get; set; }

    public string IdDocumentNumber { get; set; } = null!;

    public double Rate { get; set; }
}
