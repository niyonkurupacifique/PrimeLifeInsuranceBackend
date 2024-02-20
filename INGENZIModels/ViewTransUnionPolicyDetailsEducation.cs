using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewTransUnionPolicyDetailsEducation
{
    public string? IdentificationDocumentType { get; set; }

    public string? CustomerIdentificationDocumentNumber { get; set; }

    public string? SurnameInstitutionName { get; set; }

    public string? FirstNameTradingName { get; set; }

    public string? MiddleName { get; set; }

    public string PolicyType { get; set; } = null!;

    public string BasePolicyNumber { get; set; } = null!;

    public string? EndorsementNumber { get; set; }

    public string? EndorsementDate { get; set; }

    public string? BaseTransactionDate { get; set; }

    public string? PolicyStartDate { get; set; }

    public string? PolicyExpiryDate { get; set; }

    public int NumberOfPersonsCovered { get; set; }

    public string PolicyStatus { get; set; } = null!;

    public string Classification { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public double? InsuredAmount { get; set; }

    public double GrossPremiumAmount { get; set; }

    public double PremiumPaidToDate { get; set; }

    public int CurrentBalanceOnPolicy { get; set; }

    public string? DueDate { get; set; }

    public int DaysInArrears { get; set; }

    public int? OtherInformation { get; set; }

    public string? ReportingMonth { get; set; }
}
