using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewAnnualPaymentRenewalsOld
{
    public string Names { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string PhoneNumber1 { get; set; } = null!;

    public double LoanAmount { get; set; }

    public DateTime EndDate { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string IdBankBranch { get; set; } = null!;

    public DateTime? LoanEndDate { get; set; }

    public string BankName { get; set; } = null!;

    public string IdBank { get; set; } = null!;

    public string IdDocumentNumber { get; set; } = null!;

    public double Premium { get; set; }

    public double Fees { get; set; }

    public double TotalPremium { get; set; }
}
