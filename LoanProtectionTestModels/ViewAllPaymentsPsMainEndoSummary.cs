using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewAllPaymentsPsMainEndoSummary
{
    public string SchemeName { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string PolicyStatus { get; set; } = null!;

    public string PolicyType { get; set; } = null!;

    public string ProfitSharing { get; set; } = null!;

    public string LifeAssuredName { get; set; } = null!;

    public DateOnly? DateOfBirth { get; set; }

    public string? Gender { get; set; }

    public int EndowmentAmountDuringDifferedPeriod { get; set; }

    public int EndowmentAmountAfterDifferedPeriod { get; set; }

    public string Bonus { get; set; } = null!;

    public string PaymentMode { get; set; } = null!;

    public string PremiumPaymentFrequency { get; set; } = null!;

    public double PremiumAmountAsPerFrequency { get; set; }

    public double AnnualPremium { get; set; }

    public DateTime EffectiveDate { get; set; }

    public DateTime EndDateOfPremiumPayment { get; set; }

    public DateTime EndDateOfEndowmentPayment { get; set; }

    public int Term { get; set; }

    public int PremiumPayingTerm { get; set; }

    public int EndowmentNumberInYear { get; set; }

    public double CommissionRate { get; set; }

    public double InterestRate { get; set; }

    public double ManagementFees { get; set; }

    public double InstallmentFees { get; set; }

    public DateTime? MaxDateFormated { get; set; }

    public double TotalPaidAmount { get; set; }

    public double OutstandingAmount { get; set; }

    public DateTime? MaxPaymentDate { get; set; }

    public string DistributionPerson { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string SchemeId { get; set; } = null!;

    public string PolicyNumberChild { get; set; } = null!;

    public string? IdDocumentNumber { get; set; }

    public bool EndorsementMade { get; set; }
}
