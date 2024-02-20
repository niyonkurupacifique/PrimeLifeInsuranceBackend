using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class LoanProtectionCell
{
    public int IdRecord { get; set; }

    public string CellId { get; set; } = null!;

    public string CellName { get; set; } = null!;

    public string SectorId { get; set; } = null!;
}
