using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class AssetItem
{
    public string CodeItem { get; set; } = null!;

    public string? CategoryId { get; set; }

    public string? ItemDescription { get; set; }

    public string? Barcode { get; set; }

    public string? SerialNumber { get; set; }

    public DateTime? AquisitionDate { get; set; }

    public double? AquisitionCost { get; set; }

    public double? DepreciationYears { get; set; }

    public double? AccDepreciation { get; set; }

    public double? Nbv { get; set; }

    public string? Status { get; set; }

    public string? Comments { get; set; }

    public string? UserName { get; set; }

    public double? ValuationAmount { get; set; }
}
