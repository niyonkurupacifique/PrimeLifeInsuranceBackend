using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ListOfPoliciesWithoutPayment
{
    public string CustomerCode { get; set; } = null!;

    public string Fullname { get; set; } = null!;

    public string SchemeId { get; set; } = null!;

    public string? StartDate { get; set; }

    public string? EndDate { get; set; }

    public int Term { get; set; }

    public string PolicyComponentType { get; set; } = null!;

    public string Product { get; set; } = null!;

    public string PaymentMode { get; set; } = null!;

    public double Contribution { get; set; }

    public string? RecordDate { get; set; }

    public DateTime PolicyDate { get; set; }

    public string? PaymentChannel { get; set; }

    public string? Channel { get; set; }

    public string PolicyNumberChild { get; set; } = null!;

    public string SchemeName { get; set; } = null!;

    public string? IdDocumentNumber { get; set; }

    public string? PhoneNumber { get; set; }

    public string VendorCode { get; set; } = null!;

    public string? VendorName { get; set; }
}
