using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class DeliveryConvertedPolicy
{
    public int Id { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string? OtpNumber { get; set; }

    /// <summary>
    /// 0 stand for not yet verified and 1 is when verified
    /// </summary>
    public int? OtpVerified { get; set; }

    public string? CustPhone { get; set; }

    /// <summary>
    /// This will have 3 status such as Pending, Rejected, Accepted 
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// This may contain the feedback/reason for rejecting contract
    /// </summary>
    public string? Feedback { get; set; }

    public DateTime? DeliveryTimestamp { get; set; }

    public DateTime? OtpVerifiedTimestamp { get; set; }

    public DateTime? ConvertedTime { get; set; }

    public string? Product { get; set; }

    public string? MessageDesc { get; set; }

    /// <summary>
    /// 0 is False and 1 is True 
    /// </summary>
    public int? MessageSent { get; set; }

    public string? CustEmail { get; set; }

    public DateTime? AcceptedTimestamp { get; set; }

    public string? FullName { get; set; }
}
