using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class AdministrativeLocation
{
    public int SlNo { get; set; }

    public string? CodeProvince { get; set; }

    public string? Province { get; set; }

    public string? CodeDistrict { get; set; }

    public string? District { get; set; }

    public string? CodeSector { get; set; }

    public string? Sector { get; set; }

    public string? CodeCell { get; set; }

    public string? Cellule { get; set; }

    public string? CodeVillage { get; set; }

    public string? Village { get; set; }

    public bool Status { get; set; }

    public string? MapLocation { get; set; }
}
