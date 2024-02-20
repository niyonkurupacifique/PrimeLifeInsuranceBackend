using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class InvInvestment
{
    public int IdRecord { get; set; }

    public string InvestmentId { get; set; } = null!;

    public string? NameOfCompany { get; set; }

    public string? CompanyCountry { get; set; }

    public string? CompanySubSectorIsic { get; set; }

    public string? ListedFlag { get; set; }

    public string? StockExchangeName { get; set; }

    public string? PhoneNumber { get; set; }

    public string? EmailAddress { get; set; }

    public string? NameOfGuarantor { get; set; }

    public string? CreditRating { get; set; }

    public string? CreditRatingAgency { get; set; }

    public string? InvestmentClass { get; set; }

    public string? TypeOfInvestment { get; set; }

    public string? AssetAllocationMandate { get; set; }

    public string? IdentificationOfProperty { get; set; }

    public decimal? NumberOfUnits { get; set; }

    public decimal? PercentageOfOwnership { get; set; }

    public DateOnly? AssetAcquisitionDate { get; set; }

    public DateOnly? MaturityDate { get; set; }

    public decimal? InitialInvestment { get; set; }

    public decimal? AdditionalInvestment { get; set; }

    public decimal? CurrentValue { get; set; }

    public decimal? CapitalGain { get; set; }

    public decimal? RevaluationGain { get; set; }

    public DateOnly? DateOfValuation { get; set; }

    public string? ValuerName { get; set; }

    public string? ValuerContact { get; set; }

    public string? BasisOfValuation { get; set; }

    public decimal? RoiRate { get; set; }

    public decimal? AccruedReceivables { get; set; }

    public decimal? CashFromInvIncome { get; set; }

    public decimal? RecFromInvIncome { get; set; }

    public DateOnly? ReceivableDate { get; set; }

    public decimal? Charges { get; set; }

    public string? RelatedPartyFlag { get; set; }

    public string? RegFinInstitution { get; set; }

    public string? Names { get; set; }

    public byte[]? DocumentContent { get; set; }

    public string? Extn { get; set; }

    public DateTime? RecordedDate { get; set; }

    public string? UserName { get; set; }
}
