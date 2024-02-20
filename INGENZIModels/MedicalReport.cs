using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class MedicalReport
{
    public int IdRecord { get; set; }

    public string? DocId { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string CustomerNationalId { get; set; } = null!;

    public bool Serologie2 { get; set; }

    public bool Serologie3 { get; set; }

    public bool ProfilSanguin { get; set; }

    public bool Ecg { get; set; }

    public bool Ecbu { get; set; }

    public bool Xray { get; set; }

    public DateTime? ReportDate { get; set; }

    public DateTime? DueRenewalDate { get; set; }

    public bool DocumentStatus { get; set; }

    public string? Name { get; set; }

    public byte[]? DocumentContent { get; set; }

    public string? Extn { get; set; }

    public DateOnly? RecordedDate { get; set; }

    public string? UserName { get; set; }
}
