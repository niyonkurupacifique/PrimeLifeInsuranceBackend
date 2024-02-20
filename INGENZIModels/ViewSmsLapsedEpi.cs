using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewSmsLapsedEpi
{
    public string? LifeAssuredName { get; set; }

    public string? PhoneNumber1 { get; set; }

    public double? OutstandingAmount { get; set; }

    public DateTime? MaxDate { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string PolicyType { get; set; } = null!;
}
