using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewBnrLoanprotectionAcct
{
    public string Country { get; set; } = null!;

    public int LeBook { get; set; }

    public string AccountNo { get; set; } = null!;

    public string AccountName { get; set; } = null!;

    public string VisionOuc { get; set; } = null!;

    public string VisionSbu { get; set; } = null!;

    public int AccountStatus { get; set; }

    public DateTime AccountStatusDate { get; set; }

    public string CustomerId { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public string VisionGl { get; set; } = null!;

    public string AccountType { get; set; } = null!;

    public DateTime AccountOpenDate { get; set; }

    public DateTime AccountClosingDate { get; set; }

    public string PublicSectorCode { get; set; } = null!;

    public string InstitutionalSectorCode { get; set; } = null!;

    public string RenewalPolicyFlag { get; set; } = null!;

    public int NumOfBeneficiaries { get; set; }

    public int PolicyWrittenThru { get; set; }

    public string DateLastModified { get; set; } = null!;

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
