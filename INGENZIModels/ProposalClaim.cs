using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ProposalClaim
{
    public double? IdRecord { get; set; }

    public string? ClaimNumber { get; set; }

    public string? PolicyNumber { get; set; }

    public double? CustomerCode { get; set; }

    public string? NameOfProduct { get; set; }

    public string? ClaimType { get; set; }

    public string? SchemeName { get; set; }

    public string? PolicyholderName { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public double? SumInsured { get; set; }

    public DateTime? ClaimDateIncident { get; set; }

    public DateTime? PlaceOfIncident { get; set; }

    public DateTime? ClaimDeclarationDate { get; set; }

    public double? ClaimReserveAmount { get; set; }

    public string? ClaimStatus { get; set; }

    public string? RejectionReason { get; set; }

    public double? TotalPremiumPaid { get; set; }

    public DateTime? ClaimDateLastDocument { get; set; }

    public DateTime? ClaimSettlementDate { get; set; }

    public double? ClaimTotalAmount { get; set; }

    public double? ReinsuranceRecoverable { get; set; }

    public double? ClaimSettlementAmount { get; set; }

    public double? TotalLoan { get; set; }

    public double? InterestOnAdvance { get; set; }

    public double? AdvanceAndInterest { get; set; }

    public double? PhysicalLossIncurred { get; set; }

    public DateTime? SurrenderType { get; set; }

    public double? SurrenderValue { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? UserId { get; set; }

    public string? BeneficiaryNames { get; set; }

    public string? Telephone { get; set; }
}
