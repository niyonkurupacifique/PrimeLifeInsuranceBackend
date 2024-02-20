using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewUpdateProposalRegister
{
    public int IdRecord { get; set; }

    public string ProposalNumber { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string? SchemeId { get; set; }

    public string? PaymentMode { get; set; }

    public string? Institutions { get; set; }

    public DateTime? ProposalDate { get; set; }

    public string? Product { get; set; }

    public string? CustomerCode { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? PhoneNumber1 { get; set; }

    public bool? Converted { get; set; }

    public DateTime? ConvertedDate { get; set; }

    public string? PolicyNumber { get; set; }

    public bool? SignedAndReturned { get; set; }

    public DateTime? ReturnedDate { get; set; }

    public bool? Cancelled { get; set; }

    public DateTime? CancelledDate { get; set; }

    public string? CancelledRaison { get; set; }

    public double Premium { get; set; }

    public double? RiskPremium { get; set; }

    public double? SavingsPremium { get; set; }

    public DateOnly? DueDate { get; set; }

    public DateTime? RecordedDate { get; set; }

    public string? UserName { get; set; }

    public int PolicyTermYears { get; set; }

    public double? BenefitsInYears { get; set; }

    public string? IdfileExtension { get; set; }
}
