using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewPolicyPerUser
{
    public string CustomerCode { get; set; } = null!;

    public string? FullName { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string? PolicyNumber { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? RecordedDate { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public string? ProductCategory { get; set; }

    public double? RiskPremium { get; set; }

    public string? UserName { get; set; }

    public bool? Cancelled { get; set; }
}
