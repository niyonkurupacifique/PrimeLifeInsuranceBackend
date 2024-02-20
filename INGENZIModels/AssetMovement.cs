using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class AssetMovement
{
    public int InRecords { get; set; }

    public string CodeItem { get; set; } = null!;

    public string EmployeeId { get; set; } = null!;

    public string? ItemLocation { get; set; }

    public DateTime? AssignedDate { get; set; }

    public string? Comments { get; set; }

    public string? Status { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? UserName { get; set; }
}
