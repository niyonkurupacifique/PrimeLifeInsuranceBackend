using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ClaimsRegisterManagement
{
    public int IdRecord { get; set; }

    public string? ClaimNumber { get; set; }

    public string ClaimNumberUpdate { get; set; } = null!;

    public string? PolicyNumber { get; set; }

    public string? PolicyStatus { get; set; }

    public string? SchemeName { get; set; }

    public string? PolicyholderName { get; set; }

    public string? IdentificationNumber { get; set; }

    public string? NameOfProduct { get; set; }

    public string? TypeofClaim { get; set; }

    public string? SalesAgent { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public double? SumInsured { get; set; }

    public double? TotalPremiumPaid { get; set; }

    public DateTime? IncidentDate { get; set; }

    public DateTime? ClaimDeclarationDate { get; set; }

    public string? ClaimStatus { get; set; }

    public DateTime? SubmissionDateOfLastDocument { get; set; }

    public double? AmountOfClaimReserveCfv { get; set; }

    public double? GrossAmountPaid { get; set; }

    public double? PaidNotReimbursed { get; set; }

    public double? PenaltiesAdvanceSurrender { get; set; }

    public double? ReinsuranceRecoverable { get; set; }

    public double? CoinsuranceRecoverable { get; set; }

    public double? ManagementFee { get; set; }

    public double? NetAmountPaid { get; set; }

    public double? Interest { get; set; }

    public double? AdvanceInterest { get; set; }

    public double? AdvanceReimbursPeriod { get; set; }

    public DateTime? ClaimSettlementDate { get; set; }

    public string? BeneficiaryNames { get; set; }

    public string? PlaceOfIncident { get; set; }

    public string? Telephone { get; set; }

    public string? Gender { get; set; }

    public DateTime? Dob { get; set; }

    public string? Comments { get; set; }

    public string? RelationshipPolicyholder { get; set; }

    public string? Comment { get; set; }

    public int? NumOfPreviousClaims { get; set; }

    public double? SurrenderValue { get; set; }

    public DateTime? RecoredDate { get; set; }

    public string? CreatedByUser { get; set; }

    public DateTime? ApprovedModDate { get; set; }

    public string? ApprovedModByUser { get; set; }
}
