using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewBnrAllLifeClaim
{
    public string Country { get; set; } = null!;

    public string LeBook { get; set; } = null!;

    public string YearMonth { get; set; } = null!;

    public string? PolicyNumber { get; set; }

    public string ClaimStatus { get; set; } = null!;

    public string? RejectionReason { get; set; }

    public string? ClaimNumber { get; set; }

    public DateTime? ClaimSubmissionDate { get; set; }

    public string ClaimExpiryDate { get; set; } = null!;

    public string ClaimCurrency { get; set; } = null!;

    public double? TotalClaimAmount { get; set; }

    public int TotalLoan { get; set; }

    public string SurrenderType { get; set; } = null!;

    public int SurrenderValue { get; set; }

    public DateTime? IncidentDate { get; set; }

    public DateTime? IncidentReportDate { get; set; }

    public DateTime? PlaceOfIncident { get; set; }

    public int OccurrenceBookDetails { get; set; }

    public int NumOfPreviousClaims { get; set; }

    public int? PhysicalLossIncurred { get; set; }

    public DateTime? ClaimSettlementDate { get; set; }

    public double? ClaimSettlementAmount { get; set; }
}
