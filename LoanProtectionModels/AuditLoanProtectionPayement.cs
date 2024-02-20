using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class AuditLoanProtectionPayement
{
    public int IdRecord { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string IdBankBranch { get; set; } = null!;

    public DateTime DateOfPayement { get; set; }

    public string ReferencePayement { get; set; } = null!;

    public string? AccountNumberAndBank { get; set; }

    public DateTime? RecordDate { get; set; }

    public string UserName { get; set; } = null!;

    public string? InvoiceNumber { get; set; }

    public double? AmountPaid { get; set; }

    public string? PaymentMode { get; set; }

    public bool? IntegratedAcc { get; set; }

    public DateTime? IntegrationDate { get; set; }

    public int? ReportingYear { get; set; }

    public int? ReportingMonth { get; set; }

    public string? Operation { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }
}
