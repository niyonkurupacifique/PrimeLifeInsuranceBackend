using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class SavingsPolicyBeneficiary
{
    public int IdRecord { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string? BeneficiaryFirstname { get; set; }

    public string? BeneficiaryLastName { get; set; }

    public string? Relationship { get; set; }

    public double BenefitPercentage { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? UserName { get; set; }
}
