using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewClaimsSavingsValidation
{
    public string? NameOfProduct { get; set; }

    public string ClaimNumber { get; set; } = null!;

    public string? ClaimNumberUpdate { get; set; }

    public string? PolicyNumber { get; set; }

    public string? PolicyNumberComb { get; set; }

    public string? LastName { get; set; }

    public string? MiddleName { get; set; }

    public string? FirstName { get; set; }

    public string? PolicyholderName { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? IdentificationNumber { get; set; }

    public DateTime? ClaimDeclarationDate { get; set; }

    public DateTime? ClaimDeclarationDate1 { get; set; }

    public DateTime? ClaimDateIncident { get; set; }

    public string? ClaimStatus { get; set; }

    public string? ClaimStatus1 { get; set; }

    public double? ClaimTotalAmount { get; set; }

    public double? AmountOfClaimReserveCfv { get; set; }

    public double? TotalPremiumPaid { get; set; }

    public double? GrossAmountPaid { get; set; }

    public DateTime? ClaimSettlementDate { get; set; }

    public DateTime? ClaimSettlementDate1 { get; set; }

    public double? ClaimSettlementAmount { get; set; }

    public double? NetAmountPaid { get; set; }
}
