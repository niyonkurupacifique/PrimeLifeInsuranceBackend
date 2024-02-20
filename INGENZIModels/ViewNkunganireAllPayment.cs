using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewNkunganireAllPayment
{
    public string CustomerCode { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string? PhoneNumber1 { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public string? ProductCategory { get; set; }

    public double RiskPremium { get; set; }

    public bool Claimed { get; set; }

    public bool Surrended { get; set; }

    public string ReferencePay { get; set; } = null!;

    public string PaymentMode { get; set; } = null!;

    public string PaymentSource { get; set; } = null!;

    public DateTime PaymentDate { get; set; }

    public double AmountPayed { get; set; }

    public string ProofOfPayment { get; set; } = null!;

    public string Comments { get; set; } = null!;

    public string? UserId { get; set; }

    public string? ReportingMonths { get; set; }

    public string SchemeId { get; set; } = null!;
}
