using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ReinsuranceRegister
{
    public int IdRecord { get; set; }

    public string? ReinsuranceId { get; set; }

    public string? CustomerCode { get; set; }

    public string? CustomerNationalId { get; set; }

    public string? ProposalNumber { get; set; }

    public string? PolicyNumber { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? TypeReinsurance { get; set; }

    public decimal? TotalSumInsured { get; set; }

    public string? ReinsurerName { get; set; }

    public double? TreatyShare { get; set; }

    public decimal? ReinsuredAmount { get; set; }

    public double? PremiumRate { get; set; }

    public decimal? PremiumTotal { get; set; }

    public double? CommissionRate { get; set; }

    public decimal? CommissionAmount { get; set; }

    public double? NetPremium { get; set; }

    public bool? ReinsuranceConfirmed { get; set; }

    public DateTime? ConfirmationDate { get; set; }

    public DateTime? RecoredDate { get; set; }

    public bool? ReinsuranceStatus { get; set; }

    public string? UserName { get; set; }
}
