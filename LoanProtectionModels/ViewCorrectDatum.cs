using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewCorrectDatum
{
    public string CustomerCode { get; set; } = null!;

    public string IdDoc { get; set; } = null!;

    public string? CustCodeCust { get; set; }

    public string IdDocPolReg { get; set; } = null!;
}
