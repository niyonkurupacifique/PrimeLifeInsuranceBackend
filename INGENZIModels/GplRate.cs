using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class GplRate
{
    public int IdRecord { get; set; }

    public int Ages { get; set; }

    public double Rates { get; set; }

    public DateTime? RecordedDate { get; set; }

    public string? UserName { get; set; }
}
