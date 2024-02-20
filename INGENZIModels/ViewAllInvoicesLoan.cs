using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewAllInvoicesLoan
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

    public string? BankName { get; set; }

    public double BasicPremium { get; set; }

    public double AdministrationFee { get; set; }

    public string Comments { get; set; } = null!;

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

    public string? LoanType { get; set; }

    public double Discount { get; set; }

    public double? LoadingRate { get; set; }

    public string Retrenchment { get; set; } = null!;

    public string JointPolicy { get; set; } = null!;

    public string ReferencePay { get; set; } = null!;

    public DateTime PolicyDate { get; set; }

    public double TotalPremium { get; set; }
}
