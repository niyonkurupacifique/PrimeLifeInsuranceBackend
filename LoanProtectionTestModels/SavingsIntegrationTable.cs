using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class SavingsIntegrationTable
{
    public int Idrecord { get; set; }

    public string PaymentSource { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string CustomerNames { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string InvoiceNumber { get; set; } = null!;

    public double AmountPaid { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public DateOnly InvoiceDueDate { get; set; }

    public DateOnly? PaymentDate { get; set; }

    public bool? Integrated { get; set; }

    public DateOnly? IntegrationDate { get; set; }

    public DateOnly? AccountNumber { get; set; }

    public string Username { get; set; } = null!;
}
