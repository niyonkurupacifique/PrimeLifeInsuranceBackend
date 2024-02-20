using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewNewBusinessEducation
{
    public string? MainPolicyNumber { get; set; }

    public int? MainIdRecord { get; set; }

    public string ReferencePay { get; set; } = null!;

    public string Branch { get; set; } = null!;

    public DateTime PaymentDate { get; set; }

    public double AmountPayed { get; set; }

    public string ProofOfPayment { get; set; } = null!;

    public string Comments { get; set; } = null!;

    public DateTime? RecordedDate { get; set; }

    public string? UserId { get; set; }

    public string? ReportingMonths { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string FullName { get; set; } = null!;

    public string? PhoneNumber1 { get; set; }

    public string? PaymentSource { get; set; }

    public string? SchemeId { get; set; }

    public string PolicyType { get; set; } = null!;

    public string? DistributionChannelId { get; set; }

    public string? ChannelName { get; set; }
}
