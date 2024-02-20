using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewLoanProtectionPaymentsDetail
{
    public string CustomerCode { get; set; } = null!;

    public string Names { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public DateTime PolicyDate { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public double LoanAmount { get; set; }

    public double InsuranceRate { get; set; }

    public double Fees { get; set; }

    public double Premium { get; set; }

    public double TotalPremium { get; set; }

    public int? LoanPeriod { get; set; }

    public DateTime? LoanEndDate { get; set; }

    public string BankName { get; set; } = null!;

    public string BranchName { get; set; } = null!;

    public DateTime DateOfPayement { get; set; }

    public string ReferencePayement { get; set; } = null!;

    public string? AccountNumberAndBank { get; set; }

    public DateTime? RecordDate { get; set; }

    public string BranchCompany { get; set; } = null!;

    public string? BusinessChannel { get; set; }

    public string? VendorName { get; set; }

    public string? InvoiceNumber { get; set; }

    public double? AmountPaid { get; set; }
}
