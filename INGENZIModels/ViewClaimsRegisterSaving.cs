using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewClaimsRegisterSaving
{
    public int IdRecord { get; set; }

    public string ClaimNumber { get; set; } = null!;

    public string ClaimNumberUpdate { get; set; } = null!;

    public string? PolicyNumber { get; set; }

    public string PolicySatatus { get; set; } = null!;

    public string SchemeName { get; set; } = null!;

    public string FullNames { get; set; } = null!;

    public string? IdDocumentNumber { get; set; }

    public string PolicyType { get; set; } = null!;

    public string? TypeofClaim { get; set; }

    public string? VendorName { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public double? SumInsured { get; set; }

    public double? TotalPremiumPaid { get; set; }

    public DateTime? ClaimDateIncident { get; set; }

    public DateTime? ClaimDeclarationDate { get; set; }

    public string? ClaimStatus { get; set; }

    public DateTime? DateLastDocument { get; set; }

    public double? SurrenderValue { get; set; }

    public double? ClaimTotalAmount { get; set; }

    public double? AdvanceSurrenderNotReimbursed { get; set; }

    public double? PenaltiesAdvanceSurrenderNotReimbursed { get; set; }

    public double? ReinsuranceRecoverable { get; set; }

    public double? CoinsuranceRecoverable { get; set; }

    public double? ManagementFee { get; set; }

    public double? ClaimSettlementAmount { get; set; }

    public double? InterestOnAdvance { get; set; }

    public double? AdvanceAndInterest { get; set; }

    public double? AdvanceReimbursed { get; set; }

    public DateTime? ClaimSettlementDate { get; set; }

    public string? BeneficiaryName { get; set; }

    public string? PlaceOfIncident { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Gender { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? Comments { get; set; }

    public string? BeneficiaryRelationshipType { get; set; }

    public string? Comment { get; set; }

    public int NumOfPreviousClaims { get; set; }

    public double? SurrenderValues { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? RecordUserName { get; set; }

    public DateTime? CmapprovedDate { get; set; }

    public string? CmapprovedUserName { get; set; }
}
