using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewPolicyDetail
{
    public int _ { get; set; }

    public string SchemeNumber { get; set; } = null!;

    public string? CustomerCode { get; set; }

    public string? Date { get; set; }

    public double Rate { get; set; }

    public string PayFrequency { get; set; } = null!;

    public string BenefitsPay { get; set; } = null!;

    public string RecordedBy { get; set; } = null!;

    public string? Channel { get; set; }

    public string? ChannelType { get; set; }

    public string? RecordDate { get; set; }

    public bool? Cancelled { get; set; }

    public double? CommRate { get; set; }

    public double? ManagementFees { get; set; }

    public double? InstallmentFees { get; set; }

    public string BranchName { get; set; } = null!;

    public string? Type { get; set; }

    public string? SumAssuredType { get; set; }

    public double? PensionRate { get; set; }
}
