using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewClaimsRegisterLoanProtection
{
    public int IdRecord { get; set; }

    public string ClaimNumber { get; set; } = null!;

    public string ClaimNumberUpdate { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string AccountStatus { get; set; } = null!;

    public string? SchemeName { get; set; }

    public string? AccountName { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? Products { get; set; }

    public string ClaimType { get; set; } = null!;

    public string? VendorName { get; set; }

    public DateTime? AccountOpenDate { get; set; }

    public DateTime? AccountClosingDate { get; set; }

    public double LoanAmount { get; set; }

    public double RiskPremium { get; set; }

    public DateTime ClaimDate { get; set; }

    public DateTime DeclarationDate { get; set; }

    public string ClaimStatus { get; set; } = null!;

    public DateTime SubmissionDateOfLastDocument { get; set; }

    public double AmountOfClaimReserveCfv { get; set; }

    public double GrossAmountPaid { get; set; }

    public int PaidNotReimbursed { get; set; }

    public int PenaltiesAdvanceSurrender { get; set; }

    public int ReinsuranceRecoverable { get; set; }

    public int CoinsuranceRecoverable { get; set; }

    public int ManagementFee { get; set; }

    public double NetAmountPaid { get; set; }

    public int Interest { get; set; }

    public int AdvanceInterest { get; set; }

    public int AdvanceReimbursPeriod { get; set; }

    public DateTime ClaimSettlementDate { get; set; }

    public string? BeneficiaryNames { get; set; }

    public string PlaceOfIncident { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string? Gender { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string Comments { get; set; } = null!;

    public string RelationshipPolicyholde { get; set; } = null!;

    public string Comment { get; set; } = null!;

    public int NumOfPreviousClaims { get; set; }

    public double SurrenderValue { get; set; }

    public DateTime RecordDate { get; set; }

    public string CreatedByUser { get; set; } = null!;

    public DateTime ApprovedModDate { get; set; }

    public string ApprovedModByUser { get; set; } = null!;
}
