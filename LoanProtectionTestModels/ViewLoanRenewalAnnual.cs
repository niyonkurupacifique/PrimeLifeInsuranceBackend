using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewLoanRenewalAnnual
{
    public string FullName { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string IdDocumentNumber { get; set; } = null!;

    public double LoanAmount { get; set; }

    public double TotalPremium { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime? LoanEndDate { get; set; }

    public string BankName { get; set; } = null!;

    public string BranchName { get; set; } = null!;
}
