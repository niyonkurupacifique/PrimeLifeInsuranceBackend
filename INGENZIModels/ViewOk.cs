using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewOk
{
    public string CustomerCode { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string? IdDocumentNumber { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public DateOnly? CreationDate { get; set; }

    public DateOnly? RecordedDate { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public string ProductType { get; set; } = null!;

    public double RiskPremium { get; set; }

    public string? UserName { get; set; }

    public bool Cancelled { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public DateTime? PaymentDate { get; set; }

    public double? AmountPayed { get; set; }

    public string? UserId { get; set; }

    public string? ReportingMonths { get; set; }

    public string? VendorId { get; set; }

    public string? ChannelName { get; set; }

    public string? ChannelType { get; set; }

    public string? PremiumFrequency { get; set; }

    public int? IdRecord { get; set; }
}
