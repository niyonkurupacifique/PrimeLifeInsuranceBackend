using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewAnnualPaymentRenewal
{
    public string CustomerCode { get; set; } = null!;

    public string Names { get; set; } = null!;

    public string IdDocumentNumber { get; set; } = null!;

    public string PhoneNumber1 { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public double LoanAmount { get; set; }

    public double Premium { get; set; }

    public double Fees { get; set; }

    public double TotalPremium { get; set; }

    public string? CoverStartDate { get; set; }

    public string? CoverEndDate { get; set; }

    public string? LoanEndDate { get; set; }

    public string BankName { get; set; } = null!;

    public string IdBankBranch { get; set; } = null!;

    public string IdBank { get; set; } = null!;

    public DateTime EndDate { get; set; }

    public DateTime? LoanEndDate1 { get; set; }
}
