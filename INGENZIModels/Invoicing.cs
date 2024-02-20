using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class Invoicing
{
    public int Nauto { get; set; }

    public string? Ninvoice { get; set; }

    public DateTime? LastTransactionDate { get; set; }

    public DateTime? DueDate { get; set; }

    public string? NpolOrScheme { get; set; }

    public string? NpolOrEndorsement { get; set; }

    public string? PayementPeriod { get; set; }

    public double DueAmount { get; set; }

    public double OutstandingAmount { get; set; }

    public double AdvancePayment { get; set; }

    public string? ProductName { get; set; }

    public string? PayementMode { get; set; }

    public string? InsuredCode { get; set; }

    public string? InsuredName { get; set; }

    public string? UserCode { get; set; }

    public string? UserName { get; set; }

    public string? BranchName { get; set; }

    public string? PayerCustomerCode { get; set; }

    public string? PayerCustomerName { get; set; }

    public double TotalPolicyPremium { get; set; }
}
