using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewSms5Education
{
    public string? Names { get; set; }

    public string? Phone { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? PaymentFrequency { get; set; }

    public double? Premium { get; set; }

    public DateTime PaymentPeriod { get; set; }

    public string? PaymentMode { get; set; }

    public bool? Active { get; set; }

    public bool? Surrendered { get; set; }

    public bool? Maturred { get; set; }
}
