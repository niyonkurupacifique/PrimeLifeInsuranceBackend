using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewClaimsRegisterEducation
{
    public int IdRecord { get; set; }

    public string? ClaimNumber { get; set; }

    public string? ClaimNumberUpdate { get; set; }

    public string? PolicyNumber { get; set; }

    public string AccountStatus { get; set; } = null!;

    public string? SchemeName { get; set; }

    public string? AccountName { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? ProductName { get; set; }

    public string? ClaimType { get; set; }

    public string? VendorName { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public double? SumInsured { get; set; }

    public double? TotalPremiumPaid { get; set; }

    public DateTime? ClaimDateIncident { get; set; }

    public DateTime? ClaimDeclarationDate { get; set; }

    public string? ClaimStatus { get; set; }

    public DateTime? DateLastDocument { get; set; }

    public double? AmountOfClaimReserveCfv { get; set; }

    public double? GrossAmountPaid { get; set; }

    public int PaidNotReimbursed { get; set; }

    public int PenaltiesAdvanceSurrender { get; set; }

    public double? ReinsuranceRecoverable { get; set; }

    public int CoinsuranceRecoverable { get; set; }

    public double? ManagementFee { get; set; }

    public double? ClaimSettlementAmount { get; set; }

    public int Interest { get; set; }

    public int AdvanceInterest { get; set; }

    public int AdvanceReimbursPeriod { get; set; }

    public DateTime? ClaimSettlementDate { get; set; }

    public string? BeneficiaryNames { get; set; }

    public string? PlaceOfIncident { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Gender { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? Comments { get; set; }

    public string? Relationship { get; set; }

    public string? RejectionReason { get; set; }

    public int NumOfPreviousClaims { get; set; }

    public double? SurrenderValue { get; set; }

    public DateTime? RecordedDate { get; set; }

    public string? RecordUserName { get; set; }

    public DateTime? CmapprovedDate { get; set; }

    public string? CmapprovedUserName { get; set; }
}
