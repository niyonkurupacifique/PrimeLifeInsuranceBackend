using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewEligiblePoliciesSavingsMain
{
    public string CustomerCode { get; set; } = null!;

    public string? IdDocumentNumber { get; set; }

    public string FullName { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string EndorsementNumber { get; set; } = null!;

    public double Contribution { get; set; }

    public string PolicyType { get; set; } = null!;

    public string PolicyStatus { get; set; } = null!;

    public string? PaymentChannel { get; set; }

    public string? Channel { get; set; }

    public string SchemeId { get; set; } = null!;

    public string SchemeName { get; set; } = null!;

    public double? TotalPremiumDue { get; set; }

    public double? TotalAmountPaid { get; set; }

    public double? Outstanding { get; set; }

    public DateTime? MaxPaymentDate { get; set; }

    public string? PhoneNumber { get; set; }
}
