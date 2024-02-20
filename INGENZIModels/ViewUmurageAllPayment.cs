using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewUmurageAllPayment
{
    public string CustomerCode { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string? PhoneNumber1 { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? SchemeId { get; set; }

    public double? RiskPremium { get; set; }

    public bool? Surrendered { get; set; }

    public bool? Maturred { get; set; }

    public string? ReferencePay { get; set; }

    public string PaymentMode { get; set; } = null!;

    public string PaymentSource { get; set; } = null!;

    public DateTime? PaymentDate { get; set; }

    public double? AmountPayed { get; set; }

    public string Comments { get; set; } = null!;

    public string? UserId { get; set; }

    public int? ReportingYear { get; set; }

    public int? ReportingMonth { get; set; }

    public string? YearMonth { get; set; }
}
