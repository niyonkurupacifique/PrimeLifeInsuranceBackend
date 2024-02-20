using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewAssetRegister
{
    public int InRecords { get; set; }

    public string CodeItem { get; set; } = null!;

    public string? Barcode { get; set; }

    public string? ItemDescription { get; set; }

    public string? FullName { get; set; }

    public string? ItemLocation { get; set; }

    public string EmployeeId { get; set; } = null!;

    public string? IdJobTitle { get; set; }

    public string? CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public string? SerialNumber { get; set; }

    public DateTime? AquisitionDate { get; set; }

    public double? AquisitionCost { get; set; }

    public double? DepreciationYears { get; set; }

    public double? AccDepreciation { get; set; }

    public double? Nbv { get; set; }

    public string? Status { get; set; }

    public string? Comments { get; set; }

    public DateTime? AssignedDate { get; set; }

    public string? MvtComment { get; set; }

    public string? MvtStatus { get; set; }
}
