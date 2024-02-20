using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewIkiminaWithdraw
{
    public string PolicyNumberChild { get; set; } = null!;

    public string SchemeId { get; set; } = null!;

    public string PolicyholderName { get; set; } = null!;

    public string? IdDocumentNumber { get; set; }

    public string PolicyType { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Gender { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public double CurrentFundValue { get; set; }

    public double GossPaidAmount { get; set; }

    public double NetPaidAmount { get; set; }

    public double Fees { get; set; }

    public DateTime TransactionDate { get; set; }

    public string? ServiceProviderTransactionId { get; set; }
}
