using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewSavingsIntacctIngenziCombinedInvoice
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

    public string SchemeName { get; set; } = null!;
}
