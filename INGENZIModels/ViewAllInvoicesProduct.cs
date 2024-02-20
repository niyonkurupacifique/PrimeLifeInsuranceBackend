using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewAllInvoicesProduct
{
    public string? SchemeName { get; set; }

    public string ProductType { get; set; } = null!;

    public string? SubProductType { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string? FullName { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? Gender { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string PolicyStatus { get; set; } = null!;

    public DateTime? CreationDate { get; set; }

    public string? UnderwritingUserName { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public DateTime? LoanEndDate { get; set; }

    public int? InsurancePeriodInMonths { get; set; }

    public DateTime? EndDateOfPremiumPayment { get; set; }

    public DateTime? EndDateOfEndowmentPayment { get; set; }

    public int? PolicyTermInYear { get; set; }

    public int? PremiumPayingTermInYear { get; set; }

    public int? EndowmentNumberInYear { get; set; }

    public double? PremiumPerFrequency { get; set; }

    public double? InsuranceRate { get; set; }

    public double? EndowmentAmountDuringDifferedPeriod { get; set; }

    public double? EndowmentAmountAfterDifferedPeriod { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public double? AdministrationFee { get; set; }

    public double AccountNumberAndBank { get; set; }

    public string BankName { get; set; } = null!;

    public string? BankBranchName { get; set; }

    public string? VendorId { get; set; }

    public string? ChannelName { get; set; }

    public string? ChannelType { get; set; }

    public string? PremiumFrequency { get; set; }

    public double? PolicyholderDeathTpdSumInsured { get; set; }

    public double? PolicyholderLossOfIncomeSumInsured { get; set; }

    public double? SpouseDeathSumInsured { get; set; }

    public double? PolicyTotalFuneralFee { get; set; }

    public double? PolicyTotalSumInsured { get; set; }

    public string? LoanType { get; set; }

    public double? Discount { get; set; }

    public double? LoadingRate { get; set; }

    public string Retrenchment { get; set; } = null!;

    public string JointPolicy { get; set; } = null!;

    public string ReferencePay { get; set; } = null!;

    public DateTime? PaymentPeriod { get; set; }

    public double? Premiums { get; set; }
}
