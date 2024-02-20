using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewFamilyProvision
{
    public string PolicyNumber { get; set; } = null!;

    public int? LivesInsured { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string? Gender { get; set; }

    public string? DateOfBirth { get; set; }

    public string Expr1 { get; set; } = null!;

    public string? ProductCategory { get; set; }

    public string? EffectiveDate { get; set; }

    public string? MaturityDate { get; set; }

    public double? Premium { get; set; }

    public double? TotalPremium { get; set; }

    public double? TotalAmountPayed { get; set; }

    public double? TotaLSumInsured { get; set; }

    public DateTime? MaxPaymentDate { get; set; }

    public bool Status { get; set; }

    public double? MemberTotalSumInsured { get; set; }
}
