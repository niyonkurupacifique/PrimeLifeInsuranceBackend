using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class PartnersDocumentRequiredHistorical
{
    public int IdRecord { get; set; }

    public string DistributionChannelId { get; set; } = null!;

    public string DocId { get; set; } = null!;

    public string? DocumentRequired { get; set; }

    public DateTime? SubmisionDate { get; set; }

    public DateTime? DueRenewalDate { get; set; }

    public bool DocumentStatus { get; set; }

    public string? Name { get; set; }

    public byte[]? DocumentContent { get; set; }

    public string? Extn { get; set; }

    public DateTime? RecordedDate { get; set; }

    public string? UserName { get; set; }

    public int? DelIdRecord { get; set; }

    public string? DelByUser { get; set; }

    public DateTime? DelOnDate { get; set; }
}
