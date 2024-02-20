using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class LifeClaimsRegister
{
    public int IdRecord { get; set; }

    public string? CustomerCode { get; set; }

    public string? SchemeName { get; set; }

    public string? PolicyholderName { get; set; }

    public string? IdentificationNumber { get; set; }

    public string? LifeInsuredNames { get; set; }

    public string? PolicyNumber { get; set; }

    public string? InsuranceType { get; set; }

    public DateOnly? PolicyStartDate { get; set; }

    public DateOnly? PolicyMaturityDate { get; set; }

    public string? PolicyType { get; set; }

    public decimal? SumInsured { get; set; }

    public decimal? TotalPremiumPaid { get; set; }

    public DateOnly? LastPremiumPayDate { get; set; }

    public decimal? NumOfPersonsCovered { get; set; }

    public decimal? ClaimNumber { get; set; }

    public string? ClaimType { get; set; }

    public DateOnly? IncidentDate { get; set; }

    public DateOnly? ReportedDate { get; set; }

    public DateOnly? ClaimSubmissionDate { get; set; }

    public string? PlaceOfIncident { get; set; }

    public string? ClaimStatus { get; set; }

    public string? RejectionReason { get; set; }

    public DateOnly? ClaimExpiryDate { get; set; }

    public string? ClaimCurrency { get; set; }

    public decimal? TotalClaimAmount { get; set; }

    public string? OccurrenceBookDetails { get; set; }

    public decimal? NumOfPreviousClaims { get; set; }

    public string? PhysicalLossIncurred { get; set; }

    public DateOnly? ClaimSettlementDate { get; set; }

    public decimal? ClaimSettlementAmount { get; set; }

    public string? BeneficiaryNames { get; set; }

    public string? AnyComment { get; set; }
}
