using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewZamaraActuarialValuationLoan
{
    public string CustomerCode { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string PolicyType { get; set; } = null!;

    public string PolicyStatus { get; set; } = null!;

    public string? LoanType { get; set; }

    public string? LifeAssuredName { get; set; }

    public string? DateOfBirth { get; set; }

    public string Gender { get; set; } = null!;

    public string? EffectiveDate { get; set; }

    public string? ExpiryDateFormated { get; set; }

    public int? LoanPeriodInMonths { get; set; }

    public double LoanAmount { get; set; }

    public string BankName { get; set; } = null!;

    public double BasicPremium { get; set; }

    public double AdministrationFee { get; set; }

    public double TotalPremium { get; set; }

    public string? PremiumPaymentFrequency { get; set; }

    public double? CommissionRate { get; set; }

    public string? LoanEndDate { get; set; }

    public string IdDocumentNumber { get; set; } = null!;

    public string PhoneNumber1 { get; set; } = null!;

    public DateTime ExpiryDate { get; set; }

    public string ResidenceProvince { get; set; } = null!;

    public string ResidenceDistrict { get; set; } = null!;
}
