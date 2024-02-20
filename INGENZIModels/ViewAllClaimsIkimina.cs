using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewAllClaimsIkimina
{
    public string SchemeName { get; set; } = null!;

    public string ProductType { get; set; } = null!;

    public string SubProductType { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string? IdDocumentNumber { get; set; }

    public string? Gender { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string PolicyStatus { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public string UnderwritingUserName { get; set; } = null!;

    public DateTime EffectiveDate { get; set; }

    public DateTime MaturityDate { get; set; }

    public int? LoanEndDate { get; set; }

    public int? InsurancePeriodInMonths { get; set; }

    public DateTime EndDateOfPremiumPayment { get; set; }

    public int? EndDateOfEndowmentPayment { get; set; }

    public int PolicyTermInYear { get; set; }

    public int PremiumPayingTermInYear { get; set; }

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

    public string VendorId { get; set; } = null!;

    public string? ChannelName { get; set; }

    public string? ChannelType { get; set; }

    public string PremiumFrequency { get; set; } = null!;

    public double PolicyholderDeathTpdSumInsured { get; set; }

    public int? PolicyholderLossOfIncomeSumInsured { get; set; }

    public int? SpouseDeathSumInsured { get; set; }

    public int? PolicyTotalFuneralFee { get; set; }

    public double PolicyTotalSumInsured { get; set; }

    public string? ReportingMonths { get; set; }

    public string LoanType { get; set; } = null!;

    public int? Discount { get; set; }

    public int? LoadingRate { get; set; }

    public string Retrenchment { get; set; } = null!;

    public string JointPolicy { get; set; } = null!;

    public string? IssuedProvince { get; set; }

    public string? ResidenceProvince { get; set; }

    public string? ResidenceDistrict { get; set; }

    public string PolicyNumberMain { get; set; } = null!;

    public int? IdRecord { get; set; }
}
