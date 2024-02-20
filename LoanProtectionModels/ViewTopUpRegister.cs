using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewTopUpRegister
{
    public int IdRecord { get; set; }

    public string ClaimNumber { get; set; } = null!;

    public string ClaimType { get; set; } = null!;

    public bool? IsClaimsCancelled { get; set; }

    public string PolicyNumberOld { get; set; } = null!;

    public string BankNameOld { get; set; } = null!;

    public string BranchNameOld { get; set; } = null!;

    public DateTime ClaimDate { get; set; }

    public DateTime DeclarationDate { get; set; }

    public DateTime ClaimsRecorDate { get; set; }

    public int PeriodConsumedInDays { get; set; }

    public double LoanAmountOld { get; set; }

    public DateTime StartDateOld { get; set; }

    public DateTime EndDateOld { get; set; }

    public int? ReportingYearOld { get; set; }

    public int? ReportingMonthOld { get; set; }

    public double OutstandingAmountOld { get; set; }

    public double TotalPremiumOld { get; set; }

    public double RiskPremiumOld { get; set; }

    public double ErnedPremiumOld { get; set; }

    public double RefundAmountOld { get; set; }

    public string UsernameOld { get; set; } = null!;

    public string FullNameOld { get; set; } = null!;

    public string IdDocumentNumberOld { get; set; } = null!;

    public string PhoneNumberOld { get; set; } = null!;

    public bool IsCancelledOld { get; set; }

    public bool? PolicyClaimedStatusOld { get; set; }

    public string? NewPolicyTopUp { get; set; }

    public string BankNameNew { get; set; } = null!;

    public string BranchNameNew { get; set; } = null!;

    public DateTime StartDateNew { get; set; }

    public DateTime EndDateNew { get; set; }

    public double LoanAmountNew { get; set; }

    public double PremiumNew { get; set; }

    public double FeesNew { get; set; }

    public double TotalPremiumNew { get; set; }

    public double NewPayableAmount { get; set; }

    public bool IsCancelledNew { get; set; }

    public bool? PolicyClaimedStatusNew { get; set; }

    public string FullNameNew { get; set; } = null!;

    public string IdDocumentNumberNew { get; set; } = null!;

    public string PhoneNumberNew { get; set; } = null!;

    public string UserNameNew { get; set; } = null!;
}
