using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class View2
{
    public int IdRecord { get; set; }

    public string SchemeNumber { get; set; } = null!;

    public string IdDocumentNumber { get; set; } = null!;

    public DateTime PolicyDate { get; set; }

    public double InterestRate { get; set; }

    public string PaymentMode { get; set; } = null!;

    public string BenefitsPaymentsMode { get; set; } = null!;

    public string VendorCode { get; set; } = null!;

    public DateTime RecordDate { get; set; }

    public string UserName { get; set; } = null!;

    public bool? Cancelled { get; set; }

    public double? ManagementFees { get; set; }

    public double? InstallmentFees { get; set; }

    public string? InsuranceBranchCode { get; set; }

    public double? PensionRate { get; set; }

    public string? PolicyType { get; set; }

    public string? SumAssuredType { get; set; }

    public double? CommissionRate { get; set; }

    public string? CustomerCode { get; set; }

    public DateTime Expr1 { get; set; }
}
