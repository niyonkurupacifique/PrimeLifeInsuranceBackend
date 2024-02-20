using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewSavingsIntacctIngenziInvoiceRegisterBasePolicy
{
    public int IdRecord { get; set; }

    public string ReceiptNumber { get; set; } = null!;

    public string Product { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string InvoiceNumber { get; set; } = null!;

    public double PaidAmount { get; set; }

    public double? NetPremium { get; set; }

    public double? Fees { get; set; }

    public DateOnly DueDate { get; set; }

    public string PaymentMode { get; set; } = null!;

    public DateOnly PaymentDate { get; set; }

    public string ReceiptingBank { get; set; } = null!;

    public string InsuranceCodeBranch { get; set; } = null!;

    public string IntegratedAcc { get; set; } = null!;

    public DateOnly? IntegrationDate { get; set; }

    public string ReceiptDescription { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public double Contribution { get; set; }

    public int Term { get; set; }

    public bool Surrendered { get; set; }

    public bool Suspended { get; set; }

    public bool Cancelled { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }
}
