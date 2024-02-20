using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewUmurageAllPolicy
{
    public string CustomerCode { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string? PhoneNumber1 { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? SchemeId { get; set; }

    public double? Premium { get; set; }

    public bool? PolicyStatus { get; set; }

    public bool? Surrendered { get; set; }

    public bool? Maturred { get; set; }

    public DateTime? RecordedDate { get; set; }

    public string? CreationYearMonths { get; set; }
}
