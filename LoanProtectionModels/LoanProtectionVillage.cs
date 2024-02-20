using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class LoanProtectionVillage
{
    public int IdRecord { get; set; }

    public string VillageId { get; set; } = null!;

    public string VillageName { get; set; } = null!;

    public string CellId { get; set; } = null!;
}
