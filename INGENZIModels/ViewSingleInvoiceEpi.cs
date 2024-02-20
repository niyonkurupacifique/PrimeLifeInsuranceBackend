using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewSingleInvoiceEpi
{
    public string? SchemeName { get; set; }

    public string ProductType { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string? IdDocumentNumber { get; set; }

    public string? Gender { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string PolicyStatus { get; set; } = null!;

    public DateTime? CreationDate { get; set; }

    public string? UnderwritingUserName { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? EndDateOfPremiumPayment { get; set; }

    public int PremiumPayingTermInYear { get; set; }

    public double PremiumPerFrequency { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public string? VendorId { get; set; }

    public string? ChannelName { get; set; }

    public string? ChannelType { get; set; }

    public string? PremiumFrequency { get; set; }

    public string ReferencePay { get; set; } = null!;

    public DateTime PaymentPeriod { get; set; }

    public double? Premiums { get; set; }

    public string PolicyNumberEndo { get; set; } = null!;

    public string PolicyNumberInvoice { get; set; } = null!;

    public string SchemeId { get; set; } = null!;

    public string PaymentStatus { get; set; } = null!;
}
