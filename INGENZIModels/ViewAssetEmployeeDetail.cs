using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewAssetEmployeeDetail
{
    public string EmployeeId { get; set; } = null!;

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public DateTime? StartDate { get; set; }

    public string? NationalId { get; set; }

    public string? JobTitle { get; set; }

    public string? DepartmentName { get; set; }
}
