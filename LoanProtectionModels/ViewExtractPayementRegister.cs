using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewExtractPayementRegister
{
    public string CustomerCode { get; set; } = null!;

    public string Names { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

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

    public int? ReportingYear { get; set; }

    public int? ReportingMonth { get; set; }

    public string UserName { get; set; } = null!;

    public string? LoanType { get; set; }

    public double Discount { get; set; }

    public double? LoadingRate { get; set; }

    public bool? Retrenchment { get; set; }

    public string? PayFrequency { get; set; }

    public int? Joint { get; set; }
}
