using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewIkiminaPayment
{
    public string Expr1 { get; set; } = null!;

    public string? PhoneNumber1 { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string FullName { get; set; } = null!;

    public string ProposalNumber { get; set; } = null!;

    public double Premium { get; set; }

    public string? SavingPolicy { get; set; }

    public string? SavingsId { get; set; }

    public string? PhoneNumber { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string PolicyNumberChild { get; set; } = null!;

    public int IdRecord { get; set; }

    public string? SchemeNumber { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string ReferencePay { get; set; } = null!;

    public string PaymentChannel { get; set; } = null!;

    public string PaymentSource { get; set; } = null!;

    public DateTime? PaymentDate { get; set; }

    public double? AmountPayed { get; set; }

    public string? ProofOfPayment { get; set; }

    public string? Comments { get; set; }

    public string? UserId { get; set; }

    public bool? IntegratedAcc { get; set; }

    public DateOnly? IntegrationDate { get; set; }

    public string? CustomerCode { get; set; }

    public int? ReportingYear { get; set; }

    public int? ReportingMonth { get; set; }
}
