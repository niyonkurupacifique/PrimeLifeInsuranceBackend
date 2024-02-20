using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ReceivedSm
{
    public int IdRecord { get; set; }

    public string? PhoneNumber { get; set; }

    public string? MsgText { get; set; }

    public bool? Answer { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public string? ReceivedTime { get; set; }
}
