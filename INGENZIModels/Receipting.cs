using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class Receipting
{
    public int Nauto { get; set; }

    public string? Nreceipt { get; set; }

    public string? PaidNinvoice { get; set; }

    public DateTime? PaidDate { get; set; }

    public int PaidYear { get; set; }

    public int PaidMonth { get; set; }

    public int PaidDay { get; set; }

    public DateTime? DueDate { get; set; }

    public string? NpolOrScheme { get; set; }

    public double PaidAmount { get; set; }

    public double OutstandingAmount { get; set; }

    public double AdvancePayment { get; set; }

    public string? ProductName { get; set; }

    public string? PayementMode { get; set; }

    public string? ChecqueNumber { get; set; }

    public string? CheckIsuedBank { get; set; }

    public string? PaymentReferenceNo { get; set; }

    public string? PayerCustomerCode { get; set; }

    public string? PayerCustomerName { get; set; }

    public string? InsuredCode { get; set; }

    public string? InsuredName { get; set; }

    public string? UserCode { get; set; }

    public string? UserName { get; set; }

    public string? BranchName { get; set; }

    public string? ReceiptingBanqueInfo { get; set; }

    public DateTime? PaymentReferenceDate { get; set; }
}
