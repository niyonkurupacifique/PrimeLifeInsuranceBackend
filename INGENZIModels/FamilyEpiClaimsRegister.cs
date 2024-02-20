using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class FamilyEpiClaimsRegister
{
    public int IdRecord { get; set; }

    public string ClaimNumber { get; set; } = null!;

    public string? PolicyNumber { get; set; }

    public string? CustomerCode { get; set; }

    public string? ProductName { get; set; }

    public string? ClaimType { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public double? SumInsured { get; set; }

    public DateTime? ClaimDeclarationDate { get; set; }

    public DateTime? ClaimDateIncident { get; set; }

    public string? PlaceOfIncident { get; set; }

    public string? ClaimStatus { get; set; }

    public string? RejectionReason { get; set; }

    public double? ClaimTotalAmount { get; set; }

    public double? TotalPremiumPaid { get; set; }

    public double? ClaimReserveAmount { get; set; }

    public double? AdvanceSurrenderNotReimbursed { get; set; }

    public double? PenaltiesAdvanceSurrenderNotReimbursed { get; set; }

    public double? ReinsuranceRecoverable { get; set; }

    public double? CoinsuranceRecoverable { get; set; }

    public double? ContractBreachFree { get; set; }

    public double? ManagementFee { get; set; }

    public double? DuplicateFee { get; set; }

    public double? ClaimSettlementAmount { get; set; }

    public DateTime? ClaimSettlementDate { get; set; }

    public double? InterestOnAdvance { get; set; }

    public double? AdvanceAndInterest { get; set; }

    public double? AdvanceReimbursed { get; set; }

    public double? SurrenderValue { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? RecordUserName { get; set; }

    public DateTime? CmapprovedDate { get; set; }

    public string? CmapprovedUserName { get; set; }

    public string? Cmaction { get; set; }

    public DateTime? DateLastDocument { get; set; }

    public string? ClaimentRelationship { get; set; }

    public string? ClaimentId { get; set; }

    public bool? Letter { get; set; }

    public bool? OriginalPolicy { get; set; }

    public bool? IdlifeInsured { get; set; }

    public bool? IdofBeneficiary { get; set; }

    public bool? PowerOfAttorney { get; set; }

    public bool? Statement { get; set; }

    public bool? DuplicatelPolicy { get; set; }

    public string? Names { get; set; }

    public byte[]? DocumentContent { get; set; }

    public string? Extn { get; set; }

    public string? OperationStatus { get; set; }

    public string? Comments { get; set; }

    public string? BenefitsPayment { get; set; }

    public string? BeneficiaryRelationshipType { get; set; }

    public string? BeneficiaryId { get; set; }

    public string? BeneficiaryName { get; set; }

    public string? BeneficiaryPhone { get; set; }

    public string? BeneficiaryAccounts { get; set; }

    public string? BeneficiaryInstitution { get; set; }
}
