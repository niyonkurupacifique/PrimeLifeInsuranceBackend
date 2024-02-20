using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class PlUser
{
    public int IdRecord { get; set; }

    public string Names { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Phone { get; set; }

    public bool Active { get; set; }

    public bool? Payements { get; set; }

    public bool? Cancellation { get; set; }

    public bool? Reports { get; set; }

    public bool? Deleting { get; set; }

    public bool? Approval { get; set; }

    public bool? Limit { get; set; }

    public bool? Claims { get; set; }

    public bool Property { get; set; }

    public bool Travel { get; set; }

    public string? Manager { get; set; }

    public string? Administrator { get; set; }

    public string? EmployeeType { get; set; }

    public string? ChannelId { get; set; }

    public DateTime? RecordedDate { get; set; }

    public bool? ApprovalLevel2 { get; set; }

    public bool? ApprovalLeval3 { get; set; }

    public DateTime? LastModifiedPassDate { get; set; }

    public bool? LockedOut { get; set; }

    public int? WrongPassCount { get; set; }

    public string? PassSentSms { get; set; }
}
