using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewAllPaymentLoan
{
    public string? SchemeName { get; set; }

    public string ProductType { get; set; } = null!;

    public string SubProductType { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string IdDocumentNumber { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public string PhoneNumber1 { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string PolicyStatus { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public string UnderwritingUserName { get; set; } = null!;

    public DateTime EffectiveDate { get; set; }

    public DateTime MaturityDate { get; set; }

    public DateTime? LoanEndDate { get; set; }

    public int? InsurancePeriodInMonths { get; set; }

    public int? EndDateOfPremiumPayment { get; set; }

    public int? EndDateOfEndowmentPayment { get; set; }

    public int? PolicyTermInYear { get; set; }

    public int? PremiumPayingTermInYear { get; set; }

    public int? EndowmentNumberInYear { get; set; }

    public double PremiumPerFrequency { get; set; }

    public double InsuranceRate { get; set; }

    public int? EndowmentAmountDuringDifferedPeriod { get; set; }

    public int? EndowmentAmountAfterDifferedPeriod { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public string? ReferencePay { get; set; }

    public DateTime? PremiumPaymentDate { get; set; }

    public double BasicPremium { get; set; }

    public double AdministrationFee { get; set; }

    public double? TotalPremium { get; set; }

    public DateTime? PremiumRecordedDate { get; set; }

    public string? FinanceUserId { get; set; }

    public string? PaymentProof { get; set; }

    public string? AccountNumberAndBank { get; set; }

    public string Comments { get; set; } = null!;

    public string PrimeBranchName { get; set; } = null!;

    public string? BankName { get; set; }

    public string? BankBranchName { get; set; }

    public string? VendorId { get; set; }

    public string? ChannelName { get; set; }

    public string? ChannelType { get; set; }

    public string? PremiumFrequency { get; set; }

    public double PolicyholderDeathTpdSumInsured { get; set; }

    public int? PolicyholderLossOfIncomeSumInsured { get; set; }

    public int? SpouseDeathSumInsured { get; set; }

    public int? PolicyTotalFuneralFee { get; set; }

    public int? PolicyTotalSumInsured { get; set; }

    public string? ReportingMonths { get; set; }

    public string? LoanType { get; set; }

    public double Discount { get; set; }

    public double? LoadingRate { get; set; }

    public string Retrenchment { get; set; } = null!;

    public string JointPolicy { get; set; } = null!;

    public string? IssuedProvince { get; set; }

    public string ResidenceProvince { get; set; } = null!;

    public string ResidenceDistrict { get; set; } = null!;

    public string PolicyNumberMain { get; set; } = null!;

    public int? IdRecord { get; set; }
}
