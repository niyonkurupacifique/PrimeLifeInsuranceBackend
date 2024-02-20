using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewPolicyRegisterDetailsExtaction
{
    public string CustomerCode { get; set; } = null!;

    public string Names { get; set; } = null!;

    public string? Salutation { get; set; }

    public string Gender { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public string MaritalStatus { get; set; } = null!;

    public string Nationality { get; set; } = null!;

    public string IdDocumentType { get; set; } = null!;

    public string IdDocumentNumber { get; set; } = null!;

    public string? Email { get; set; }

    public string PhoneNumber1 { get; set; } = null!;

    public string BankName { get; set; } = null!;

    public string BranchName { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public double LoanAmount { get; set; }

    public double InsuranceRate { get; set; }

    public double Fees { get; set; }

    public double Premium { get; set; }

    public double TotalPremium { get; set; }

    public DateTime PolicyDate { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime RecordDate { get; set; }

    public int? LoanPeriod { get; set; }

    public DateTime? LoanEndDate { get; set; }

    public bool? Paid { get; set; }

    public string? PayFrequency { get; set; }

    public string? Channel { get; set; }

    public string? InsuranceBranchCode { get; set; }

    public string BranchName1 { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string? PaymentChannel { get; set; }

    public string IdBank { get; set; } = null!;
}
