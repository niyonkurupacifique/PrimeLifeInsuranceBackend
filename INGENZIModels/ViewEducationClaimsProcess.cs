using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewEducationClaimsProcess
{
    public string? Comments { get; set; }

    public string? ClaimNumber { get; set; }

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

    public double? ReinsuranceRecoverable { get; set; }

    public double? ClaimSettlementAmount { get; set; }

    public DateTime? ClaimSettlementDate { get; set; }

    public double? TotalLoan { get; set; }

    public double? PhysicalLossIncurred { get; set; }

    public string? SurrenderType { get; set; }

    public double? SurrenderValue { get; set; }

    public DateTime? RecordedDate { get; set; }

    public string? RecordUserName { get; set; }

    public DateTime? CmapprovedDate { get; set; }

    public string? CmapprovedUserName { get; set; }

    public string? Cmaction { get; set; }

    public DateTime? DateLastDocument { get; set; }

    public DateTime? TdapprovedDate { get; set; }

    public string? TdapprovedUserName { get; set; }

    public string? Tdaction { get; set; }

    public DateTime? CeoapprovedDate { get; set; }

    public string? CeoapprovedUserName { get; set; }

    public string? Ceoaction { get; set; }

    public string? ClaimentId { get; set; }

    public string? Relationship { get; set; }

    public bool? Letter { get; set; }

    public bool? OriginalPolicy { get; set; }

    public bool? IdlifeInsured { get; set; }

    public bool? IdofBeneficiary { get; set; }

    public bool? PowerOfAttorney { get; set; }

    public bool? Statement { get; set; }

    public string? Names { get; set; }

    public byte[]? DocumentContent { get; set; }

    public string? Extn { get; set; }

    public string? OperationStatus { get; set; }

    public string? ClaimentNames { get; set; }

    public string FullName { get; set; } = null!;

    public string? Gender { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string? ChannelName { get; set; }

    public double? AmountPaid { get; set; }

    public double? Premium { get; set; }

    public double? InitialPremium { get; set; }

    public string? PaymentFrequency { get; set; }

    public int IdRecord { get; set; }

    public int? Differed { get; set; }

    public int? EndwomentNumber { get; set; }

    public bool? DuplicatelPolicy { get; set; }

    public double? ContractBreachFree { get; set; }

    public double? ManagementFee { get; set; }

    public double? DuplicateFee { get; set; }

    public bool? Printed { get; set; }
}
