using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewAllPaymentPsEndox
{
    public string? SchemeName { get; set; }

    public string ProductType { get; set; } = null!;

    public string? SubProductType { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string? IdDocumentNumber { get; set; }

    public string? Gender { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public bool PolicyStatus { get; set; }

    public DateTime CreationDate { get; set; }

    public string UnderwritingUserName { get; set; } = null!;

    public DateTime EffectiveDate { get; set; }

    public DateTime MaturityDate { get; set; }

    public int? LoanEndDate { get; set; }

    public int? InsurancePeriodInMonths { get; set; }

    public DateTime EndDateOfPremiumPayment { get; set; }

    public int? EndDateOfEndowmentPayment { get; set; }

    public int PolicyTermInYear { get; set; }

    public int? PremiumPayingTermInYear { get; set; }

    public int? EndowmentNumberInYear { get; set; }

    public double PremiumPerFrequency { get; set; }

    public int? InsuranceRate { get; set; }

    public int? EndowmentAmountDuringDifferedPeriod { get; set; }

    public int? EndowmentAmountAfterDifferedPeriod { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public string? ReferencePay { get; set; }

    public DateTime? PremiumPaymentDate { get; set; }

    public double? BasicPremium { get; set; }

    public int? AdministrationFee { get; set; }

    public double? TotalPremium { get; set; }

    public int? PremiumRecordedDate { get; set; }

    public string? FinanceUserId { get; set; }

    public string? PaymentProof { get; set; }

    public string AccountNumberAndBank { get; set; } = null!;

    public string? Comments { get; set; }

    public string PrimeBranchName { get; set; } = null!;

    public string BankName { get; set; } = null!;

    public string BankBranchName { get; set; } = null!;

    public string? VendorId { get; set; }

    public string? ChannelName { get; set; }

    public string? ChannelType { get; set; }

    public string? PremiumFrequency { get; set; }

    public int? PolicyholderDeathTpdSumInsured { get; set; }

    public int? PolicyholderLossOfIncomeSumInsured { get; set; }

    public int? SpouseDeathSumInsured { get; set; }

    public int? PolicyTotalFuneralFee { get; set; }

    public int? PolicyTotalSumInsured { get; set; }

    public string? ReportingMonths { get; set; }

    public string LoanType { get; set; } = null!;

    public int? Discount { get; set; }

    public int? LoadingRate { get; set; }

    public int? Retrenchment { get; set; }

    public int? JointPolicy { get; set; }

    public int? IdRecord { get; set; }
}
