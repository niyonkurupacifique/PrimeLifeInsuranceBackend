using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewTransUnionPolicyDetailsLoan
{
    public string IdentificationDocumentType { get; set; } = null!;

    public string CustomerIdentificationDocumentNumber { get; set; } = null!;

    public string SurnameInstitutionName { get; set; } = null!;

    public string FirstNameTradingName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string PolicyType { get; set; } = null!;

    public string BasePolicyNumber { get; set; } = null!;

    public int? EndorsementNumber { get; set; }

    public int? EndorsementDate { get; set; }

    public string? BaseTransactionDate { get; set; }

    public string? PolicyStartDate { get; set; }

    public string? PolicyExpiryDate { get; set; }

    public int NumberOfPersonsCovered { get; set; }

    public string PolicyStatus { get; set; } = null!;

    public string Classification { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public double InsuredAmount { get; set; }

    public double GrossPremiumAmount { get; set; }

    public double PremiumPaidToDate { get; set; }

    public int CurrentBalanceOnPolicy { get; set; }

    public string? DueDate { get; set; }

    public int DaysInArrears { get; set; }

    public int? OtherInformation { get; set; }
}
