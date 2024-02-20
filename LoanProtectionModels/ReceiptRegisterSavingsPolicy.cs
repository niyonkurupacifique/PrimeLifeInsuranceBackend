using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ReceiptRegisterSavingsPolicy
{
    public string CustomerCode { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public double Contribution { get; set; }

    public string ReceiptNumber { get; set; } = null!;

    public string Product { get; set; } = null!;

    public string InvoiceNumber { get; set; } = null!;

    public double PaidAmount { get; set; }

    public DateOnly DueDate { get; set; }

    public DateOnly PaymentDate { get; set; }

    public string ReceiptDescription { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string BranchName { get; set; } = null!;
}
