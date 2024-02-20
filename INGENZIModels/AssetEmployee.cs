using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class AssetEmployee
{
    public string EmployeeId { get; set; } = null!;

    public string? FullName { get; set; }

    public DateTime? StartDate { get; set; }

    public string? NationalId { get; set; }

    public string? DepartmentId { get; set; }

    public string? IdJobTitle { get; set; }

    public bool Status { get; set; }
}
