using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class View3
{
    public string PolicyNumber { get; set; } = null!;

    public string ReferencePay { get; set; } = null!;

    public DateTime PaymentDate { get; set; }

    public string TrueRef { get; set; } = null!;

    public DateTime PaymentPeriod { get; set; }
}
