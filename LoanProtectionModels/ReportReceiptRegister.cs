using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ReportReceiptRegister
{
    public string CustomerCode { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public DateTime PolicyDate { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public double LoanAmount { get; set; }

    public double TotalPremium { get; set; }

    public double Discount { get; set; }

    public string? Reference { get; set; }

    public string? PaymentChannel { get; set; }

    public double? BankCommissions { get; set; }

    public double? AgentCommisions { get; set; }

    public double? LoadingRate { get; set; }

    public string? LoanType { get; set; }

    public string ReceiptNumber { get; set; } = null!;

    public string Product { get; set; } = null!;

    public string InvoiceNumber { get; set; } = null!;

    public double PaidAmount { get; set; }

    public DateOnly DueDate { get; set; }

    public DateOnly PaymentDate { get; set; }

    public string? BankName { get; set; }

    public string? Currency { get; set; }

    public string ReceiptDescription { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string BranchName { get; set; } = null!;
}
