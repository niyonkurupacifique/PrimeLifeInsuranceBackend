using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewIkiminaOnLinePayment
{
    public string CustomerCode { get; set; } = null!;

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

    public string TransactionId { get; set; } = null!;

    public string Status { get; set; } = null!;

    public double? Amount { get; set; }

    public DateTime RecordedDate { get; set; }
}
