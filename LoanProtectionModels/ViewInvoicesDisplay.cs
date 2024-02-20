using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewInvoicesDisplay
{
    public int Period { get; set; }

    public string InvoiceNumber { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public DateTime? DueDate { get; set; }

    public string? SchemeNumber { get; set; }

    public double Contribution { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? CustomerCode { get; set; }

    public bool? EndorsementMade { get; set; }

    public DateTime StartDate { get; set; }
}
