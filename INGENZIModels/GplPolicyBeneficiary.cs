using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class GplPolicyBeneficiary
{
    public int IdRecord { get; set; }

    public string? PolicyNumberDetails { get; set; }

    public string? CustomerCode { get; set; }

    public string? BeneficiaryCode { get; set; }

    public string? BeneficiaryFullName { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? Relationship { get; set; }

    public string? MobileNumber { get; set; }

    public string? IdDocumentNumber { get; set; }

    public bool? Status { get; set; }

    public string? NextOfKin { get; set; }

    public double? Percentages { get; set; }

    public int? SharePourcentage { get; set; }
}
