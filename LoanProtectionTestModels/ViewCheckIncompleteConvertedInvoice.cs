using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewCheckIncompleteConvertedInvoice
{
    public string SchemeId { get; set; } = null!;

    public string PolicyNumberChild { get; set; } = null!;

    public string PaymentMode { get; set; } = null!;

    public double InterestRate { get; set; }

    public double ManagementFees { get; set; }

    public double CommissionRate { get; set; }

    public double InstallmentFees { get; set; }

    public int Term { get; set; }

    public double Contribution { get; set; }

    public string PolicyType { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public double PensionRate { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string FullNames { get; set; } = null!;

    public string? PhoneNumber { get; set; }
}
