using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ListOfSendingList
{
    public int IdRecord { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public DateOnly DueDate { get; set; }

    public string? FullName { get; set; }

    public string? PhoneNumber { get; set; }

    public bool Sent { get; set; }

    public double Premium { get; set; }

    public DateOnly SentDate { get; set; }

    public int RemainingDays { get; set; }

    public string? SchemeId { get; set; }
}
