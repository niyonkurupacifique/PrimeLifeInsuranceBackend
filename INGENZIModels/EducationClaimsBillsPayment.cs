using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class EducationClaimsBillsPayment
{
    public int IdRecord { get; set; }

    public string? ClaimNumber { get; set; }

    public string? PolicyNumber { get; set; }

    public string? CustomerCode { get; set; }

    public string? ProductName { get; set; }

    public string? ClaimType { get; set; }

    public string? ClaimBillNumber { get; set; }

    public double? ClaimAmountPaid { get; set; }

    public DateTime? BillPaiementDate { get; set; }

    public string? BankAccount { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Comments { get; set; }

    public string? PaymentMode { get; set; }

    public string? BankName { get; set; }

    public DateTime? RecordedDate { get; set; }

    public string? RecordUserName { get; set; }
}
