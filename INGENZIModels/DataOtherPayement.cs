using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class DataOtherPayement
{
    public string? SchemeName { get; set; }

    public string? ProductType { get; set; }

    public string? SubProductType { get; set; }

    public string? CustomerCode { get; set; }

    public string? FullName { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string? PolicyNumber { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? UnderwritingUserName { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public double? PolicyTermInYear { get; set; }

    public string? ReferencePay { get; set; }

    public DateTime? PremiumPaymentDate { get; set; }

    public double? TotalPremium { get; set; }

    public DateTime? PremiumRecordedDate { get; set; }

    public string? FinanceUserId { get; set; }

    public string? PaymentProof { get; set; }

    public string? ReportingMonths { get; set; }
}
