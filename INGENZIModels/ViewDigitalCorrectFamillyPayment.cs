using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewDigitalCorrectFamillyPayment
{
    public int IdRecord { get; set; }

    public string TransactionId { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string? PhoneNumber1 { get; set; }

    public string Status { get; set; } = null!;

    public string? Product { get; set; }

    public string? ExternalReference { get; set; }

    public string? ReferenceId { get; set; }

    public double? Amount { get; set; }

    public DateTime RecordedDate { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string? IdDocumentNumber { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public bool Claimed { get; set; }

    public bool Surrended { get; set; }
}
