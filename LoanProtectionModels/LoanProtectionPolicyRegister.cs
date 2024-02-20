using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class LoanProtectionPolicyRegister
{
    public int IdRecord { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string IdInsuranceCompany { get; set; } = null!;

    public string IdBankBranch { get; set; } = null!;

    public string IdDocumentNumber { get; set; } = null!;

    public double LoanAmount { get; set; }

    public double InsuranceRate { get; set; }

    public double Fees { get; set; }

    public double Premium { get; set; }

    public double TotalPremium { get; set; }

    public DateTime PolicyDate { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string UserName { get; set; } = null!;

    public bool IsCancelled { get; set; }

    public string CustomerCode { get; set; } = null!;

    public double Discount { get; set; }

    public DateTime RecordDate { get; set; }

    public string? Reference { get; set; }

    public int? LoanPeriod { get; set; }

    public DateTime? LoanEndDate { get; set; }

    public bool? Retrenchment { get; set; }

    public bool? Paid { get; set; }

    public string? BusinessChannel { get; set; }

    public string? VendorCode { get; set; }

    public string? InsuranceBranchCode { get; set; }

    public int? CoverPeriod { get; set; }

    public bool? Approved { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApprovalDate { get; set; }

    public string? PaymentChannel { get; set; }

    public double? BankCommissions { get; set; }

    public double? AgentCommisions { get; set; }

    public string? PayFrequency { get; set; }

    public string UnikRow { get; set; } = null!;

    public double? AcquisitionCost { get; set; }

    public double? AdministrationFees { get; set; }

    public double? CompanyInterest { get; set; }

    public bool? Claim { get; set; }

    public string? LoanType { get; set; }

    public double? RetrechementRate { get; set; }

    public double? LoadingRate { get; set; }
}
