using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class LoanProtectionCrbpoliciesDetail
{
    public string? IdentificationDocumentType { get; set; }

    public string? CustomerIdentificationDocumentNumber { get; set; }

    public string? SurnameInstitutionName { get; set; }

    public string? FirstNameTradingName { get; set; }

    public string? MiddleName { get; set; }

    public string? PolicyType { get; set; }

    public string? BasePolicyNumber { get; set; }

    public string? EndorsementNumber { get; set; }

    public string? EndorsementDate { get; set; }

    public DateTime? BaseTransactionDate { get; set; }

    public DateTime? PolicyStartDate { get; set; }

    public DateTime? PolicyExpiryDate { get; set; }

    public double? NumberOfPersonsCovered { get; set; }

    public string? PolicyStatus { get; set; }

    public string? Classification { get; set; }

    public string? Currency { get; set; }

    public double? InsuredAmount { get; set; }

    public double? GrossPremiumAmount { get; set; }

    public double? PremiumPaidToDate { get; set; }

    public double? CurrentBalanceOnPolicy { get; set; }

    public DateTime? DueDate { get; set; }

    public double? DaysInArrears { get; set; }

    public string? OtherInformation { get; set; }
}
