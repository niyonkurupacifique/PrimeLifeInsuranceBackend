using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class EducationAnnuitiesBill
{
    public int IdRecord { get; set; }

    public string? ClaimNumber { get; set; }

    public string? BillNumber { get; set; }

    public string? PolicyNumber { get; set; }

    public string? CustomerCode { get; set; }

    public DateTime? DueDate { get; set; }

    public double? AnnuityAmount { get; set; }

    public string? TypeOfPayment { get; set; }

    public bool? PaymentStatus { get; set; }

    public DateTime? RecordedDate { get; set; }

    public string? RecordUserName { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string? PayUserName { get; set; }
}
