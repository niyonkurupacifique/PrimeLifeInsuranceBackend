using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class GplQuoteTempDetail
{
    public int IdRecord { get; set; }

    public string PolicyNumberBase { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public double Salary { get; set; }

    public DateTime? RecordedDate { get; set; }

    public string? UserName { get; set; }
}
